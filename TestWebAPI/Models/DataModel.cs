using System.ComponentModel.DataAnnotations;

namespace TestWebAPI.Models
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
