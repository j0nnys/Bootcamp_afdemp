using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Books
    {
        public static int _ID = 0;

        public string Title { get; private set; }
        public Author Author { get; private set; }
        public int ID { get; private set; }

        public Books(string title, Author author)
        {
            this.Title = title;
            this.Author = author;
            this.ID = ++_ID;
        }

        public override string ToString()
        {
            return $"{this.Title} by {this.Author}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Books))
            {
                return false;
            }
            return Equals(obj as Books);
        }

        public bool Equals(Books other)
        {
            if (this.ID == other.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Books book1, Books book2)
        {
            return book1.Equals(book2);
        }

        public static bool operator !=(Books book1, Books book2)
        {
            return !book1.Equals(book2);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
