namespace BooksAndAuthors
{
    /// <summary>
    /// Application class.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            // TODO : Custom serialization and deserialization
            Author au = new Author();
            au.Name = "john smith";
            au.Email = "johnsmityMail";
            au.Serialize();

            // Author au2 = Author.Derialize(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp\Week 8\TEST\data.txt");

            // Console.WriteLine(au2.Name);
        }
    }
}
