using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        // private struct BookAvailability holds information about availability of a book in this library
        class BookAvailability
        {
            public int physicalCopies;
            public int availableCopies;
        }

        private List<Users> AuthorizedUsers;
        private List<Books> books;
        private List<BookAvailability> availability;

        // private Dictionary<Book, BookAvailability> books = new Dictionary<Book, BookAvailability>();

        public Library()
        {
            AuthorizedUsers = new List<Users>();
            books = new List<Books>();
            availability = new List<BookAvailability>();
        }

        public bool IsAuthorizedUser(Users user)
        {
            if (AuthorizedUsers.Contains(user))
            {
                return true;
            }
            return false;
        }

        public void AddUser(Users user)
        {
            if (AuthorizedUsers.Contains(user))
            {
                return;
            }
            AuthorizedUsers.Add(user);
        }

        public void AddBook(Books book, int copies)
        {
            if (books.Contains(book))
            {
                int index = books.IndexOf(book);
                availability[index].physicalCopies += copies;
                availability[index].availableCopies += copies;
                return;
            }
            books.Add(book);
            availability.Add(new BookAvailability
            {
                availableCopies = copies,
                physicalCopies = copies
            });
        }

        public bool RentBook(Books book)
        {
            if (books.Contains(book))
            {
                int index = books.IndexOf(book);
                availability[index].availableCopies -= 1;
                return true;
            }
            else return false;
        }

        public bool ReturnBook(Books book)
        {
            if (books.Contains(book))
            {
                int index = books.IndexOf(book);
                availability[index].availableCopies += 1;
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            string result = String.Format("{0, -40} | {1} \n\n", "Books", "Available Copies");
            for (int i = 0; i < books.Count; i++)
            {
                result += String.Format("{0, -40} | {1} / {2} \n", books[i], availability[i].availableCopies, availability[i].physicalCopies);
            }
            return result;
        }
    }
}
   