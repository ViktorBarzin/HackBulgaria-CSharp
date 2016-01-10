namespace XmlBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class XmlBuilder
    {
        private readonly StringBuilder xml = new StringBuilder();
        private readonly Stack<string> openedTags = new Stack<string>();

        public string Tag { get; private set; }

        public XmlBuilder OpenTag(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }

            for(int i = 0; i < this.openedTags.Count; i++)
            {
                this.xml.Append("    ");
            }
            this.xml.Append(string.Format("<{0}>", name));
            this.xml.AppendLine();
            this.Tag = name;
            this.openedTags.Push(this.Tag);
            return this;
        }

        public XmlBuilder AddAttr(String attrName, String attrValue)
        {
            if (this.openedTags.Count == 0)
            {
                throw new InvalidOperationException("No opened tags.");
            }

            StringBuilder newTag = new StringBuilder(this.openedTags.Peek());
            newTag.Insert(newTag.Length, string.Format(" {0}=\"{1}\"", attrName, attrValue));
            this.Tag = newTag.ToString();
            this.xml.Replace(this.openedTags.Pop(), this.Tag);
            this.openedTags.Push(this.Tag);
            return this;
        }

        public XmlBuilder AddText(string text)
        {
            this.xml.Append(text);
            return this;
        }

        public XmlBuilder CloseTag()
        {
            this.Tag = this.openedTags.Peek();
            for (int i = 0; i < this.openedTags.Count - 1; i++)
            {
                this.xml.Append("    ");
            }
            this.xml.Append(string.Format("</{0}>", this.openedTags.Pop()));
            this.xml.AppendLine();
            //this.xml.Append("    ");
            return this;
        }

        public XmlBuilder Finish()
        {
            while (this.openedTags.Count > 0)
            {
                this.CloseTag();
            }

            return this;
        }

        public string GetResult()
        {
            return this.xml.ToString();
        }
    }
}
