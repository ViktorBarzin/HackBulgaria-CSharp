namespace Application.cs
{
    using System;
    using XmlBuilder;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Appliction
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            XmlBuilder newXml = new XmlBuilder();

            // Console.WriteLine(
            Console.WriteLine(newXml.OpenTag("gosho")
                .CloseTag()
                //.OpenTag("gosho")
                //.AddAttr("atrr", "value")
                //.OpenTag("tageName3")
                //.CloseTag()
                //.Finish()
                .GetResult());

            // .AddText("text")

            // .AddAttr("AtributeName", "AtributeValue")
            // .CloseTag()
            // .Finish()
            // .GetResult());
        }
    }
}
