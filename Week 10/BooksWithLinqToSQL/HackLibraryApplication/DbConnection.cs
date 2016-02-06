using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackLibraryApplication
{
    using System.Data.SqlClient;
    using System.Net.Sockets;

    public class DbConnection : IDisposable
    {
        private readonly HackLibraryDataContext context;

        public DbConnection(HackLibraryDataContext context)
        {
            this.context = context;
        }

        public bool Insert(Book book)
        {
            try
            {
                this.context.Books.InsertOnSubmit(book);
                this.context.SubmitChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool Insert(Author author)
        {
            try
            {
                this.context.Authors.InsertOnSubmit(author);
                this.context.SubmitChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public IEnumerable<Book> GetBooks()
        {
            return this.context.Books.OrderBy(x => x.Title);
        }
        
        public IEnumerable<Genre> GetAuthorGenres(Author author)
        {
            // TODO : abra-cadabra works?
            return from g in this.context.Genres
                   join bg in this.context.BookGenres on g.Id equals bg.GenreId
                   join b in this.context.Books on bg.GenreId equals b.GenreId
                   join ab in this.context.AuthorBooks on b.ISBN equals ab.BookISBN
                   where author.Id==ab.AuthorId
                   select g;
            /*USE HackLibrary
            SELECT *
            FROM Genre g
            JOIN BookGenre bg
            ON g.Id=bg.GenreId
            JOIN Book b
            ON b.GenreId=bg.GenreId
            JOIN AuthorBook ab
            ON ab.BookISBN=b.ISBN
            JOIN Author a
            ON ab.AuthorId=a.Id
            */
        }
        
        public IEnumerable<Book> GetAllBooksBy(Author author)
        {
            // TODO : check if this magic works
            return from b in this.context.Books
                   join ab in this.context.AuthorBooks on b.ISBN equals ab.BookISBN
                   where author.Id==ab.AuthorId
                   select b;
            /*SELECT *
            FROM Book b
            JOIN AuthorBook ab
            ON b.ISBN = ab.BookISBN
            JOIN Author a
            ON a.Id = ab.AuthorId
            */
        }

        public Book GetBookInfo(long isbn)
        {
            // TODO : check if selects correct
            return this.context.Books.Select(x => x).Where(y => y.ISBN == isbn).Take(1).FirstOrDefault();
        }

        public Book GetBookInfo(string title)
        {
            return
                this.context.Books.OrderBy(a => a.Title)
                    .Select(x => x)
                    .Where(y => y.Title.StartsWith(title) || y.Title.Contains(title) || y.Title.EndsWith(title))
                    .Take(1)
                    .SingleOrDefault();
        }

        public bool Borrow(Loan loan)
        {
            Book book = this.context.Books.Select(x => x).Where(y => y.ISBN == loan.BookISBN).Take(1).FirstOrDefault();
            try
            {
                if (book != null && this.context.Books.Contains(book))
                {
                    book.Copies -= 1;
                }
                else
                {
                    throw new ArgumentException("Book does not exist!");
                }

                this.context.Loans.InsertOnSubmit(loan);
                this.context.SubmitChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool Return(Loan loan)
        {
            History loanHistory = new History
            {
                UserId = loan.UserId,
                BookISBN = loan.BookISBN,
                LeantDate = loan.LeantDate,
                ReturnDate = loan.ExpectedReturnDate
            };

            Book returnedBook = this.context.Books.Select(x => x).Where(y => y.ISBN == loan.BookISBN).Take(1).FirstOrDefault();

            try
            {
                if (returnedBook != null)
                {
                    returnedBook.Copies += 1;
                }
                else
                {
                    throw new ArgumentException("You tried to return a book that is no in the library!");
                }
                this.context.Histories.InsertOnSubmit(loanHistory);
                this.context.Loans.DeleteOnSubmit(loan);
                this.context.SubmitChanges();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
