using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Users
    {
        public static int _ID = 0;

        public string Name { get; private set; }
        public int ID { get; private set; }

        public Users(string name)
        {
            this.Name = name;
            this.ID = ++_ID;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}

        

   
