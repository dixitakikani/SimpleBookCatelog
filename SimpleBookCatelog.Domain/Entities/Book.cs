using SimpleBookCatelog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookCatelog.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Provide a title")]
        [StringLength(100)]
        public string? Title { get; set; }
        [Required(ErrorMessage ="Please provide a auther's name")]
        [StringLength(100)]
        public string? Author { get; set; }
        [Required] 
        public DateTime PublicationDate { get; set; }

        [EnumDataType(typeof(Category),ErrorMessage ="Please select a category")]
        public Category Category { get; set; }
    }
}
