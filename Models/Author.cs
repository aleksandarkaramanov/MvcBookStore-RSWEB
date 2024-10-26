using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcBookStore.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        
        [StringLength(50)]
        [Display(Name = "Nationality")]
        public string? Nationality { get; set; }

        
        [StringLength(50)]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}