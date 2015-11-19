using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Comunication.MySocket
{
    public class Seriver : IServer
    {
        private Socket socketHeartBeat;
        private List<Socket> List_SocketServer = new List<Socket>();
        public void StartListen()
        {
            int Port = 10000;
            string LocalIP = "127.0.0.1";
            var ipAdrees = Dns.GetHostEntry(Dns.GetHostName()).AddressList[3];
            var ipAdress1 = Dns.Resolve(IPAddress.Any.ToString()).AddressList[0];

            IPEndPoint epHeartBeat = new IPEndPoint(IPAddress.Parse(LocalIP), Port);
            socketHeartBeat = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketHeartBeat.Bind(epHeartBeat);
            socketHeartBeat.Listen(20);

            var thread = new Thread(new ThreadStart(Listent)) { IsBackground = true };
            thread.Start();
        }

        public void Listent()
        {
            while (true)
            {
                try
                {
                    Socket socket = socketHeartBeat.Accept();
                    if (!List_SocketServer.Contains(socket))
                    {
                        List_SocketServer.Add(socket);

                        var thread = new Thread(new ParameterizedThreadStart(RecieveMsg)) { IsBackground = true };
                        thread.Start(socket);
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }

        public void RecieveMsg(object pSocket)
        {
            try
            {
                while (true)
                {
                    Socket socket = (Socket)pSocket;
                    if (socket != null)
                    {
                        byte[] arrMsg = new byte[1024 * 64];
                        int len = socket.Receive(arrMsg);
                        if (len == 0)
                        {
                            continue;
                        }
                        byte[] newByte = new byte[len];
                        Array.Copy(arrMsg, 0, newByte, 0, len);
                        List<byte[]> listByte = UnPackMsg(newByte);
                        if (listByte == null)
                        {
                            continue;
                        }
                        else
                        {
                            foreach (var item in listByte)
                            {
                                string str = Encoding.UTF8.GetString(item);
                                //由于切割的包可能会再次粘起来或者没有切割完美，极少极少会出现这种情况，因为一旦出现了 就是数据丢失。
                                int count = (from c in str where c == 'H' select c).Count();
                                if (count > 1)
                                {
                                    // 数据丢失
                                    continue;
                                }

                                ByteAnalysis(item, item.Length);
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 防止粘包进行的拆包
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public List<byte[]> UnPackMsg(byte[] buffer)
        {
            List<byte[]> res = new List<byte[]>();

            string strBuffer = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            if (strBuffer.StartsWith("H"))
            {
                return null;
            }
            string[] strList = strBuffer.Split('H');
            foreach (var item in strList)
            {
                if (item != string.Empty)
                {
                    string tempStr = "H" + item;
                    res.Add(Encoding.UTF8.GetBytes(tempStr));
                }
            }

            return res;
        }

        public void ByteAnalysis(byte[] arrMsg, int len)
        {
            //获取包头
            byte[] type = new byte[1];
            Array.Copy(arrMsg, 0, type, 0, 1);
            string packHead = Encoding.UTF8.GetString(type, 0, type.Length);
            if (packHead != "H")
            {
                return;
            }

            //获取校验值 异或校验
            byte[] xor = new byte[2]; //接收到的异或值
            Array.Copy(arrMsg, len - 3, xor, 0, 2);

            byte[] xor2 = new byte[2]; //自检的异或值
            arrMsg[len - 3] = 0;
            arrMsg[len - 2] = 0;
            byte[] tempMsg = new byte[len];
            Array.Copy(arrMsg, 0, tempMsg, 0, len);

            xor2 = Check(tempMsg);
            if (!xor2[0].Equals(xor[0]) || !xor2.Equals(xor[1]))
            {
                return;
            }

            //命令字：区分并进入对应函数
            byte[] byteCmd = new byte[4];
            Array.Copy(arrMsg, 1, byteCmd, 0, 4);
            string strCmd = Encoding.UTF8.GetString(byteCmd, 0, byteCmd.Length);

            //包长：有效数据的长度
            byte[] bytePackLen = new byte[4];
            Array.Copy(arrMsg, 5, bytePackLen, 0, 4);
            string strPackLen = Encoding.UTF8.GetString(bytePackLen, 0, bytePackLen.Length);
            int packLen = Int32.Parse(strPackLen);

            //包体：有效数据
            byte[] bodyByte = new byte[packLen];
            Array.Copy(arrMsg, 9, bodyByte, 0, packLen);

        }

        private byte[] Check(byte[] tempMsg)
        {
            throw new NotImplementedException();
        }
    }
}
