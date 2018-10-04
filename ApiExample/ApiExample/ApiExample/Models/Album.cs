using System;
using System.Collections.Generic;
using System.Text;

namespace ApiExample.Models
{
    public class Album
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }

        #region OneToMany
        public List<Photo> Photos { get; set; }
        #endregion
    }
}
