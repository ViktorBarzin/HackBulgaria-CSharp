namespace XmlBuilderTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using XmlBuilder;

    [TestClass()]
    public class XmlBuilderTests
    {
        [TestMethod()]
        public void OpenTagTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("gosho");
            Assert.AreEqual(xml.GetResult(), "<gosho>");
        }

        [TestMethod()]
        public void AddAttrTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("gosho");
            xml.AddAttr("AtrName", "AtrValue");
            Assert.AreEqual(xml.GetResult(), "<gosho AtrName=\"AtrValue\">");
        }

        [TestMethod()]
        public void AddTextTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("gosho");
            xml.AddText("text");
            Assert.AreEqual(xml.GetResult(), "<gosho>text");
        }

        [TestMethod()]
        public void CloseTagTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("gosho");
            xml.CloseTag();
            Assert.AreEqual(xml.GetResult(), "<gosho></gosho>");
        }

        [TestMethod()]
        public void FinishTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("gosho");
            xml.Finish();
            Assert.AreEqual(xml.GetResult(), "<gosho></gosho>");
        }

        [TestMethod()]
        public void GetResultTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("gosho");
            xml.GetResult();
            Assert.AreEqual(xml.GetResult(), "<gosho>");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void OpenTagNullValueTest()
        {
            var xml = new XmlBuilder();
            xml.OpenTag(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void CloseNotOpenedTag()
        {
            var xml = new XmlBuilder();
            xml.CloseTag();
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void CloseTagsAfterFinish()
        {
            var xml = new XmlBuilder();
            xml.OpenTag("a").Finish().CloseTag();
        }

    }
}