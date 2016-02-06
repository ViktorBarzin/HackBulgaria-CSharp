namespace BooksAndAuthors
{
    using System;

    /// <summary>
    /// IAuthor serializer interface.
    /// </summary>
    public interface IAuthorSerializer : IFormattable
    {
        /// <summary>
        /// Serializes a object with given path.
        /// </summary>
        /// <param name="obj">File path.</param>
        void Serialize(object obj);

        /// <summary>
        /// Deserializes an Author object from a file.
        /// </summary>
        /// <param name="obj">File path.</param>
        void Derialize(object obj);
    }
}
