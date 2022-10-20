using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment : BaseEntity
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string CommentContent { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

    }
}
