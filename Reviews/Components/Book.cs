using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Reviews.Components
{
    public class Book
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float? Rate { get; set; }
        public string? ImageURL { get; set; }
    }
}
