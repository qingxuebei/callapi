

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;


namespace CallAPI
{
    public static class GetAPI
    {
        public static T GetJson<T>(string url, Encoding encoding = null)
        {
            string returnText = RequestUtility.HttpGet(url, encoding);


            if (returnText.Contains("errcode"))
            {
                //可能发生错误

            }

            T result = JsonConvert.DeserializeObject<T>(returnText);

            return result;
        }

        public static T GetJson<T>(String url, CookieContainer cookieContainer = null, Encoding encoding = null, int timeOut = Config.TIME_OUT)
        {
            string returnText = RequestUtility.HttpGetTimeOut(url, cookieContainer, encoding, timeOut);
            if (returnText.Contains("errcode"))
            {
                //可能发生错误
            }

            T result = JsonConvert.DeserializeObject<T>(returnText);

            return result;
        }

        public static void Download(string url, Stream stream)
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData(url);
            foreach (var b in data)
            {
                stream.WriteByte(b);
            }
        }
    }
}
