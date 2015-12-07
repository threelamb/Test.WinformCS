using Common.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Comunication
{
    public class SocketClient
    {
        private static byte[] result = new byte[1024];
        static Dictionary<string, Socket> SocketList = new Dictionary<string, Socket>();

        public static bool ConnectServer(SocketPara para)
        {
            bool res = false;

            var sock = Connect(para);
            if (sock != null)
            {
                Socket clientSocket;
                if (SocketList.TryGetValue(para.ID, out clientSocket))
                {
                    try
                    {
                        clientSocket.Shutdown(SocketShutdown.Both);
                        clientSocket.Close();
                    }
                    catch (Exception)
                    {
                    }
                    SocketList.Remove(para.ID);
                }

                SocketList.Add(para.ID, sock);
                res = true;
            }

            return res;
        }

        private static Socket Connect(SocketPara para)
        {
            //设定服务器IP地址  
            IPAddress ip = IPAddress.Parse(para.IP);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, para.Port)); //配置服务器IP与端口  
                Log.WriteLine("连接服务器成功");
            }
            catch
            {
                Log.WriteLine("连接服务器失败");
                return null;
            }
            //通过clientSocket接收数据  
            int receiveLength = clientSocket.Receive(result);
            Log.WriteLine("接收服务器消息：{0}" + Encoding.ASCII.GetString(result, 0, receiveLength));
            //通过 clientSocket 发送数据  
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Thread.Sleep(1000);    //等待1秒钟  
                    string sendMessage = "client send Message Hellp" + DateTime.Now;
                    clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                    Log.WriteLine("向服务器发送消息：{0}" + sendMessage);
                }
                catch
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    break;
                }
            }
            Log.WriteLine("发送完毕");

            return clientSocket;
        }
    }
}
