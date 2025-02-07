using System.ComponentModel.DataAnnotations;
namespace BulkyWeb.Models
{
    public class Categoy
    {
        [Key] //primary key
        public int Id { get; set; }
        [Required] //not null setting
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
