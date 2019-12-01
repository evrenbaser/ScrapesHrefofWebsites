using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace NetcoreScrapesHrefsofWebPagesAgainInAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //List<string> hrefslist = new List<string>();

            string url = "http://www.haber7.com/";
            //HtmlWeb htmlDoc = new HtmlWeb();
            //HtmlDocument doc = htmlDoc.Load(url);
            //var alinks = doc.DocumentNode.SelectNodes("//a").ToList();

            //foreach (var aitems in alinks)
            //{
            //    try
            //    {
            //        aitems.Attributes["href"].Value.ToString();
            //        hrefslist.Add(aitems.Attributes["href"].Value.ToString());
            //        Console.WriteLine(aitems.Attributes["href"].Value.ToString());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.WriteLine(e);
            //        Console.ResetColor();
            //    }
            //}

            //foreach (var hrefitem in hrefslist)
            //{
            //    Console.WriteLine(hrefitem);
            //}


         
             List<string> hrefliste =ATagParse(url);
             ListCount(hrefliste);
            foreach (var href in hrefliste)
             {
                 if (href == null)
                 {
                     break;
                 }
                 List<string> hrefliste2= ATagParse(href);
                 ListCount(hrefliste2);
                 foreach (var href2 in hrefliste2)
                {
                    if (href2 == null)
                    {
                        break;
                    }
                    List<string> hrefliste3 = ATagParse(href2);
                    ListCount(hrefliste3);
                    foreach (var href3 in hrefliste3)
                    {
                        if (href3 == null)
                        {
                            break;
                        }
                        List<string> hrefliste4 = ATagParse(href3);
                        ListCount(hrefliste4);
                        foreach (var href4 in hrefliste4)
                        {
                            if (href4 == null)
                            {
                                break;
                            }
                            List<string> hreflist5 = ATagParse(href4);
                            ListCount(hreflist5);
                        }
                    }
                 }
             }
        }

        public static List<string> ATagParse(string url)
        {
            List<string> hrefslist = new List<string>();
            try
            {
                HtmlWeb htmlDoc = new HtmlWeb();
                HtmlDocument doc = htmlDoc.Load(url);
                var alinks = doc.DocumentNode.SelectNodes("//a").ToList();
                foreach (var aitems in alinks)
                {
                    try
                    {
                        aitems.Attributes["href"].Value.ToString();
                        hrefslist.Add(aitems.Attributes["href"].Value.ToString());
                        Console.WriteLine(aitems.Attributes["href"].Value.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(e);
                        Console.ResetColor();
                    }


                }
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();

            }
     

                
           
             
                return hrefslist;


          

        }

        public static void ListCount(List<string> liste)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(liste.Count);
            Console.ResetColor();
        }

        public static void ListDuplicate(List<string> liste)
        { 

        }

    }
}
