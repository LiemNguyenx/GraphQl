using System;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace GraphAPI.Models
{
    [Table("GlobalConfiguration")]
    public class GlobalConfiguration : EntityBase
    {
        [Index("INDEX_MIN")]
        public float? Min { get; set; }

        [Index("INDEX_MAX")]
        public float? Max { get; set; }

        public Guid ConfigTypeId { get; set; }
        [ForeignKey("ConfigTypeId")]
        public ConfigurationType ConfigurationType { get; set; }
    }
}
