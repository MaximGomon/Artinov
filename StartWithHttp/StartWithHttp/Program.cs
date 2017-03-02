using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace StartWithHttp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            WebRequest request = WebRequest.Create(@"http://www.google.com.ua");
            request.Method = WebRequestMethods.Http.Get;
            HttpWebResponse responce = (HttpWebResponse)request.GetResponse();
            Console.WriteLine("Http status code: {0}", responce.StatusCode);
            Console.WriteLine("Responce URI: {0}", responce.ResponseUri.AbsoluteUri);

            using (var responceStream = responce.GetResponseStream())
            {
                using (var streamReader = new StreamReader(responceStream, Encoding.Default))
                {
                    string responceText = streamReader.ReadToEnd();
                    File.WriteAllText("D:\\test.html", responceText);

                    Regex reg = new Regex("<img[^>]+src=\"([^ \">]+)\"");
                    var result = reg.Matches(responceText);

                    foreach (Match item in result)
                    {
                        int firstIndex = item.Value.IndexOf("\"");
                        int lastIndex = item.Value.LastIndexOf("\"");

                        Console.WriteLine(item.Value.Substring(firstIndex + 1, lastIndex - firstIndex - 1));
                    }
                    

                    //Process p = new Process();
                    //p.StartInfo = new ProcessStartInfo("D:\\test.html");
                    //p.Start();
                    //Thread.Sleep(10000);
                    
                    //Console.WriteLine(responceText);
                }
            }


            Console.ReadLine();
        }
    }
}
