using System.ComponentModel.DataAnnotations;
using System.IO;
namespace MvcBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int? YearPublished { get; set; }

        public int? NumPage { get; set; }

        [Required]
        [MaxLength(-1)]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public string? Publisher { get; set; }

        [Required]
        [MaxLength(-1)]
        public string? FrontPage { get; set; }

        [Required]
        [MaxLength(-1)]
        public string? DownloadUrl { get; set; }

        public int AuthorId { get; set; }
        public Author Author {get;set;}
        public ICollection<BookGenre>? Books { get; set; }
        public ICollection<Review>? Reviews { get; set; }

        public ICollection<UserBooks>? UserBooks{ get; set; }




    }
}
