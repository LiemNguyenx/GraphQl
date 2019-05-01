using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphAPI.Models
{
    [Table("ConfigurationType")]
    public class ConfigurationType : EntityBase
    {
        [MaxLength(1000)]
        public string Name { get; set; }
    }
}
