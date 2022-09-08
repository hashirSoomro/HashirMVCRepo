namespace WebApplication1.Models.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.Id==id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="GreatBookMVC",Author="Hashir"},
                new BookModel(){Id=2,Title="Dotnet Core",Author="Hussain"},
                new BookModel(){Id=3,Title="PHP",Author="WebGentle"},
                new BookModel(){Id=4,Title="WebCore",Author="WebGentle"},
                new BookModel(){Id=5,Title="WebHello",Author="GentleSoomro"}

            };
        }
    }
}
