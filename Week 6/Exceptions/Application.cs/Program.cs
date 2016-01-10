namespace Application.cs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using XmlBuilder;

    public class Appliction
    {
        public static void Main(string[] args)
        {
            XmlBuilder newXml = new XmlBuilder();
            //Console.WriteLine(
            Console.WriteLine(newXml.OpenTag("tagName").OpenTag("tagName2").AddAttr("atrr","value").OpenTag("tageName3").Finish().GetResult());
            

            //.AddText("text")

            //.AddAttr("AtributeName", "AtributeValue")
            //.CloseTag()
            //.Finish()
            //.GetResult());
        }
    }
}
