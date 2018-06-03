using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //HtmlDocument document2 = new HtmlDocument();
           // document2.Load(@"C:\Temp\sample.txt");

            var url = "http://http://executeautomation.com/demosite/Login.html";
            var web = new HtmlWeb();
            var document2 = web.Load(url);

            HtmlNode[] nodes = document2.DocumentNode.SelectNodes(".//*").ToArray();
            foreach (HtmlNode item in nodes)
            {
                Console.WriteLine(item.InnerHtml);
            }

            //read under specific node
            /* HtmlNode[] nodes = document2.DocumentNode.SelectNodes("//a").ToArray();
             foreach (HtmlNode item in nodes)
             {
                 Console.WriteLine(item.InnerHtml);
             }
             */

        }
    }
}
