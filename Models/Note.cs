using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }
        
        //Navigation Property
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
