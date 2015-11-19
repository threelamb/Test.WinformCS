using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comunication.MySocket
{
    public interface IServer
    {
        void StartListen();
        void RecieveMsg(object pSocket);
        List<byte[]> UnPackMsg(byte[] buffer);
        void ByteAnalysis(byte[] item, int len);
    }
}
