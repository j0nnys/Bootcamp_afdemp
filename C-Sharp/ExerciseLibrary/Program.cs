using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>
            {
                new Author("Tom Robbins"),
                new Author("Nikos Kazatzakis")
            };

            List<Books> books = new List<Books>()
            {
                new Books("To aroma tou oneirou", authors[0]),
                new Books("Ta 7 pepla", authors[0]),
                new Books("Kapetan Mixalis", authors[1])
            };

            Library library = new Library();

            library.AddBook(books[0], 10);
            library.AddBook(books[2], 5);

            Users user1 = new Users("Maria");
            Users user2 = new Users("Kostas");

            Librarian librarian = new Librarian("Takis", library);

            librarian.AddUser(user1);

            string reply;
            librarian.RentBook(user1, books[0], out reply);
            Console.WriteLine(reply);
            librarian.RentBook(user1, books[2], out reply);
            Console.WriteLine(reply);
            librarian.RentBook(user1, books[1], out reply);
            Console.WriteLine(reply);
            librarian.RentBook(user2, books[0], out reply);
            Console.WriteLine(reply);

            Console.WriteLine(library);

            Console.ReadKey();
        }
    }
}
        }
    }
}
