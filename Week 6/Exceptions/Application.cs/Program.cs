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
            Console.WriteLine(newXml.OpenTag("tagName").OpenTag("tagName2").AddAttr("atrr", "value").OpenTag("tageName3").Finish().GetResult());

            // .AddText("text")

            // .AddAttr("AtributeName", "AtributeValue")
            // .CloseTag()
            // .Finish()
            // .GetResult());
        }
    }
}
