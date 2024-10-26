using Microsoft.AspNetCore.Mvc.Rendering;
using MvcBookStore.Models;
using System.Collections.Generic;
namespace MvcBookStore.ViewModels
{
    public class BookGenreViewModel
    {
        public IList<Book> Books { get; set; }
        public SelectList Genres { get; set; }
        public string BookGenre { get; set; }
        public string SearchString { get; set; }
    }
}
