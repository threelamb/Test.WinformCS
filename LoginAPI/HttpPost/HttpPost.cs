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
            string retString = string.Empty;

            try
            {
                byte[] dataArray = Encoding.UTF8.GetBytes(str);
                request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = Method.Post;
                request.ContentType = ContentType.Json;
                request.Accept = Accept.All;
                request.KeepAlive = false;
                request.ContentLength = dataArray.Length;
                //StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.UTF8);
                var writer = request.GetRequestStream();
                writer.Write(dataArray, 0, dataArray.Length);
                writer.Flush();
                writer.Close();

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (Exception e1)
                {
                    throw;
                }
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码  
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                retString = reader.ReadToEnd();
                reader.Close();

                if (response != null) response.Close();
                if (request != null) request.Abort();

                return retString;
            }
            catch (Exception e2)
            {
                throw;
            }
        }
    }

    class ContentType
    {
        internal const string Json = "application/json";
    }

    class Accept
    {
        internal const string All = "*/*";
    }

    class Method
    {
        internal const string Get = "GET";
        internal const string Post = "POST";
    }
}
