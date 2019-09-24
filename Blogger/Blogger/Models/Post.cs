using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public class Post
    {
        public string Body { get; set; } = "";
        public string Title { get; set; } = "";
        public DateTime Creation { get; set; } = DateTime.Now;
    }
}
