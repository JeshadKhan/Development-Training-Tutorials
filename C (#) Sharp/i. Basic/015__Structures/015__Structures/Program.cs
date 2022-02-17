using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15__Structures
{
    class Program
    {
        struct Books
        {
            private string title;
            private string author;
            private string subject;
            private int book_id;
            public void getValues(string t, string a, string s, int id)
            {
                title = t;
                author = a;
                subject = s;
                book_id = id;
            }
            public void display()
            {
                Console.WriteLine("Title :\t\t{0}", title);
                Console.WriteLine("Author :\t{0}", author);
                Console.WriteLine("Subject :\t{0}", subject);
                Console.WriteLine("Book_id :\t{0}", book_id);
            }

        }

        public static void Main(string[] args)
        {
            Books Book1 = new Books();   /* Declare Book1 of type Book */
            Books Book2 = new Books();   /* Declare Book2 of type Book */

            /* book 1 specification */
            Book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 specification */
            Book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

            /* print Book1 info */
            Book1.display();

            Console.WriteLine("\n");

            /* print Book2 info */
            Book2.display();

            Console.ReadKey();
        }
    }
}
