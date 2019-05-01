using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace GraphAPI.Models
{
    [Table("MastConfiguration")]
    public class MastConfiguration : EntityBaseNotId
    {
        [Key]
        public Guid ConfigTypeId { get; set; }
        [ForeignKey("ConfigTypeId")]
        public ConfigurationType ConfigurationType { get; set; }

        [Key]
        public Guid MastId { get; set; }
        [ForeignKey("MastId")]
        public Mast Mast { get; set; }

        [Index("INDEX_MIN")]
        public float? Min { get; set; }

        [Index("INDEX_MAX")]
        public float? Max { get; set; }
    }
}
