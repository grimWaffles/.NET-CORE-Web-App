using System.ComponentModel.DataAnnotations;

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
