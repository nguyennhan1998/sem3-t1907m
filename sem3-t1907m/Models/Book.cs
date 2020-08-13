using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_t1907m.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Asset/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Asset/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elip", Author = "Tempor", CoverImage = "Asset/3.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "Asset/4.png" });
            books.Add(new Book { BookId = 5, Title = "Fegait Eros Libex", Author = "Accumsan", CoverImage = "Asset/5.png" });
            books.Add(new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "Asset/6.png" });
            books.Add(new Book { BookId = 7, Title = "Per Modo", Author = "Vero Tation", CoverImage = "Asset/7.png" });
            books.Add(new Book { BookId = 8, Title = "Susciptit Ad", Author = "Jack Tibbles", CoverImage = "Asset/8.png" });
            books.Add(new Book { BookId = 9, Title = "Decima", Author = "Tuffy Tibbles", CoverImage = "Asset/9.png" });
            books.Add(new Book { BookId = 10, Title = "Errat", Author = "Volupat", CoverImage = "Asset/10.png" });
            books.Add(new Book { BookId = 11, Title = "Cosequat", Author = "Est Possim", CoverImage = "Asset/11.png" });
            books.Add(new Book { BookId = 12, Title = "Aliquip", Author = "Magna", CoverImage = "Asset/12.png" });
            books.Add(new Book { BookId = 13, Title = "Nonummy", Author = "Tempor", CoverImage = "Asset/13.png" });
              return books;
        }

    }
}
