using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    public class Category
    {
        [Key]
        public int CatergoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWord { get; set; }

        public virtual ICollection<Product> products { get; set; }

    }
}
