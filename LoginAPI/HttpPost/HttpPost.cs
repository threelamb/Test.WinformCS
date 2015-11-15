using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace LoginAPI.HttpPost
{
    class HttpPost
    {
        private readonly string Url = Config.GetAppSetting("LoginConfig", "Url");

        public string Post(string str)
        {
            HttpWebRequest request;
            HttpWebResponse response;
            
            request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "text/xml";
            request.Accept = "application/x-javascript";
            request.ContentLength = str.Length;
            StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
            writer.Write(str); 
            writer.Flush();
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                throw;
            }

            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码  
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;
        }
    }
}
