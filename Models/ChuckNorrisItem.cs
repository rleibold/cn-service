using System.ComponentModel.DataAnnotations.Schema;

namespace cn_service.Models
{
    [Table("chuck_norris_item")]
    public class ChuckNorrisItem
    {
        public string Id { get; set; }
        public string Joke { get; set; }
    }
}