using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        /*Lİste ve Icollection arasındaki farklar*/
        public ICollection<Blog> Blogs { get; set; }
    }
}
