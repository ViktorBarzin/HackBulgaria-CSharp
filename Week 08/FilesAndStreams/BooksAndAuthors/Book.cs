namespace BooksAndAuthors
{
    using System;

    /// <summary>
    /// Book class.
    /// </summary>
    [Serializable]
    public class Book
    {
        /// <summary>
        /// Gets or sets the title property.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the publish date.
        /// </summary>
        public DateTime PublishDate { get; set; }
    }
}
