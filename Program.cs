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

            var url = "http://executeautomation.com/demosite/Login.html";
            var web = new HtmlWeb();
            var document2 = web.Load(url);

            /* select all nodes within the particular tag
             HtmlNode[] nodes = document2.DocumentNode.SelectNodes(".//form/*").ToArray();
               foreach (HtmlNode item in nodes)
               {
                   Console.WriteLine(item.InnerHtml);
               }
               */

            //select all iput nodes
            HtmlNode docNode = document2.DocumentNode;
            HtmlNodeCollection nodes = docNode.SelectNodes("//input"); //SelectNodes takes a XPath expression
            foreach (HtmlNode node in nodes)
            {
                String id = node.GetAttributeValue("id", "NoId");    // Fetch id of HTML element
                String name = node.GetAttributeValue("name", "NoName");  // Fetch parameter name (GET/POST)
                String type = node.GetAttributeValue("type", "NoType");  // Fetch type of input element
                String xPath = node.XPath;                                   
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
