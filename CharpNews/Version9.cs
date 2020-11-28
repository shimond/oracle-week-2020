using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpNews
{
    class Version9
    {
        public record BookRecord(string Title, string Author, string ISBN, int Pages);
        public static void TestIt()
        {
            Product p = new Product() { Id = 11 };
            //p.Id = 123;  // error. init only property
        }

        public static void UseRecords()
        {

            var bookRec = new BookRecord("Atomic Habits", "James Clear", "978-0735211292", 320);

            //deconstruct 
            var (title, author, _, _) = bookRec;
            
            var otherBookRec = new BookRecord("Atomic Habits", "James Clear", "978-0735211292", 320);
            Console.WriteLine(bookRec);
            Console.WriteLine(otherBookRec);
            Console.WriteLine(bookRec == otherBookRec); // True, because values are the same
            Console.WriteLine(bookRec.Equals(otherBookRec)); // True, because values are the same

        }

        class Product
        {
            // init only
            public int Id { get; init; }
        }

    }
}
