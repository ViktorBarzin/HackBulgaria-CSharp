using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackLibraryApplication
{
    using System.Data.SqlClient;

    public class DbConnection : IDisposable
    {
        private HackLibraryDataContext context;

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

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
