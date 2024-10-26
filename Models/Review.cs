using System.ComponentModel.DataAnnotations;

namespace MvcBookStore.Models
{
    public class Review
    {

        public int Id { get; set; }

        public int BookId { get; set; }

        [Required]
        [StringLength(450)]
        [Display(Name = "AppUser")]
        public string AppUser { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        public int? Rating { get; set; }
        public Book Book { get; set; }



    }
}
