namespace BooksAndAuthors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    /// <summary>
    /// Author class.
    /// </summary>
    [Serializable]
    public class Author
    {
        /// <summary>
        /// Gets or sets the name property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email for the author.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets list of books the author has.
        /// </summary>
        public List<Book> Books { get; set; }

        /// <summary>
        /// Deserializes a custom file.
        /// </summary>
        /// <param name="fileName">Path to the file to deserializes.</param>
        /// <returns>A deserialized instance of the Author class.</returns>
        public static Author Derialize(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter f = new BinaryFormatter();
                Author s1 = (Author)f.Deserialize(fs);
                return s1;
            }
        }

        /// <summary>
        /// Serializes the current instance of the Author class.
        /// </summary>
        public void Serialize()
        {
            string fileName = string.Format(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 8\TEST\" + this.Name + " Serialized.txt");
            FileInfo file = new FileInfo(fileName);
            using (FileStream s = new FileStream(file.ToString(), FileMode.Create, FileAccess.ReadWrite))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, this);
            }
        }
    }
}
