namespace SortingBooksAndMagazines
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class for sorting magazines and books.
    /// </summary>
    public static class MagazineAndBookSorter
    {
        /// <summary>
        /// Sort method which sorts books and magazines by Title/Name then by ID/ISBN.
        /// </summary>
        /// <param name="books">List of books.</param>
        /// <param name="magazines">list of magazines.</param>
        /// <returns>List of strings which is the sorted titles of the books and magazines.</returns>
        public static List<string> Sort(List<Book> books, List<Magazine> magazines)
        {
            var res = books.Select(x => new { x.Name, x.Id }).ToList();
            res.AddRange(magazines.Select(x => new { Name = x.Title, Id = x.Isbn }).ToList());
            res = res.OrderBy(x => x.Name).ThenBy(x => x.Id).ToList();
            return res.Select(x => x.Name).ToList();
        }
    }
}
