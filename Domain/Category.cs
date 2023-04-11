using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestAPI.Domain
{
    public class Category : Entity
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<Game> Games { get; set; }
    }
}
