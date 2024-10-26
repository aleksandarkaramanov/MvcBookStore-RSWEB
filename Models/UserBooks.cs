using System.ComponentModel.DataAnnotations;

namespace MvcBookStore.Models
{
    public class UserBooks
    {

        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        [Display(Name = "AppUser")]
        public string AppUser { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }


    }
}
