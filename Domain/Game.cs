using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Domain
{
    public class Game : Entity
    {
        public string CategoryName => Category?.Name ?? string.Empty;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
