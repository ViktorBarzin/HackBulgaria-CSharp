namespace XmlBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// XML builder class.
    /// </summary>
    public class XmlBuilder
    {
        /// <summary>
        /// Contains entire xml.
        /// </summary>
        private readonly StringBuilder xml = new StringBuilder();

        /// <summary>
        /// contains opened tags.
        /// </summary>
        private readonly Stack<string> openedTags = new Stack<string>();

        /// <summary>
        /// Gets or set a tag.
        /// </summary>
        public string Tag { get; private set; }

        /// <summary>
        /// Opens a new tag.
        /// </summary>
        /// <param name="name">Tag name.</param>
        /// <returns>This for chaining.</returns>
        public XmlBuilder OpenTag(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < this.openedTags.Count; i++)
            {
                this.xml.Append("    ");
            }

            this.xml.Append(string.Format("<{0}>", name));
            //this.xml.AppendLine();
            this.Tag = name;
            this.openedTags.Push(this.Tag);
            return this;
        }

        /// <summary>
        /// Adds and attribute.
        /// </summary>
        /// <param name="attrName">Attribute name.</param>
        /// <param name="attrValue">Attribute value.</param>
        /// <returns>This for chaining.</returns>
        public XmlBuilder AddAttr(string attrName, string attrValue)
        {
            if (this.openedTags.Count == 0)
            {
                throw new InvalidOperationException("No opened tags.");
            }

            // StringBuilder newTag = new StringBuilder(this.openedTags.Peek());
            // newTag.Insert(newTag.Length, string.Format(" {0}=\"{1}\"", attrName, attrValue));
            string temp = this.Tag.ToString();
            this.Tag = new StringBuilder(this.openedTags.Peek()).Insert(
                this.Tag.Length,
                string.Format(" {0}=\"{1}\"", attrName, attrValue))
                .ToString();
            this.xml.Replace(this.openedTags.Peek(), this.Tag);
            this.Tag = temp;
            //this.openedTags.Push(this.Tag);
            return this;
        }

        /// <summary>
        /// Adds text.
        /// </summary>
        /// <param name="text">The text to add.</param>
        /// <returns>This for chaining.</returns>
        public XmlBuilder AddText(string text)
        {
            this.xml.Append(text);
            return this;
        }

        /// <summary>
        /// Closes an opened tag.
        /// </summary>
        /// <returns>This for chaining.</returns>
        public XmlBuilder CloseTag()
        {
            this.Tag = this.openedTags.Peek();
            for (int i = 0; i < this.openedTags.Count - 1; i++)
            {
                this.xml.Append("    ");
            }

            this.xml.Append(string.Format("</{0}>", this.openedTags.Pop()));
            //this.xml.AppendLine();

            // this.xml.Append("    ");
            return this;
        }

        /// <summary>
        /// Closes all opened tags if any.
        /// </summary>
        /// <returns>This for chaining.</returns>
        public XmlBuilder Finish()
        {
            while (this.openedTags.Count > 0)
            {
                this.CloseTag();
            }

            return this;
        }

        /// <summary>
        /// Gets the entire xml string.
        /// </summary>
        /// <returns>Entire xml as string.</returns>
        public string GetResult()
        {
            return this.xml.ToString();
        }
    }
}
