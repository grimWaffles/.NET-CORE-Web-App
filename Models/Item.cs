using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Item
    {
        [Key]  //makes this field the primary key of the class
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        public string ItemName { get; set; }

    }
}
