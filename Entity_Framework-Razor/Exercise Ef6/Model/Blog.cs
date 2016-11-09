using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise_Ef6.Model
{
   public class Blog
        {
            //Primary Key
            public int Id { get; set; }
            public string Title { get; set; }

            //Navigation Property
            public virtual ICollection<Post> Posts { get; set; }
        }
}
