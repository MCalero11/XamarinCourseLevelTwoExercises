using System;
using System.Collections.Generic;
using System.Text;

namespace ApiExample.Models
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        #region OneToMany
        public List<Comment> Comments { get; set; }
        #endregion
    }
}
