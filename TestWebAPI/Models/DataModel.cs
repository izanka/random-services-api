using System.ComponentModel.DataAnnotations;

namespace RandomServicesAPI.Models
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
