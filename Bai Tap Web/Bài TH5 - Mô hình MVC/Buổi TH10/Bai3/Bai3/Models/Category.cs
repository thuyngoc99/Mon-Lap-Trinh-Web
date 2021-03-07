using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai3.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime DateCreate { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}