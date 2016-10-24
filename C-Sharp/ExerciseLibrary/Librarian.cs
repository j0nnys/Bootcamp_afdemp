using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{ 
    class Librarian
    {
        public string Name { get; set; }
        public Library ManagedLibrary { get; private set; }

        public Librarian (string name, Library library)
        {
            Name = name;
            ManagedLibrary = library;
        }

        public void AddUser(Users user)
        {
            ManagedLibrary.AddUser(user);
        }

            public bool RentBook (Users user, Books book, out string reply)
        {
            if (ManagedLibrary.IsAuthorizedUser(user))
            {
                if (ManagedLibrary.RentBook(book))
                {
                    reply = "Book rented succesfully. Take care of your book.";
                    return true;
                }
                reply = "No copy available.";
                return false;
            }
            reply = "You are not authorized to rent books from this library.";
            return false;
        }
     }
 }

