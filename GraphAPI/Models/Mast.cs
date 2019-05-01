using System;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace GraphAPI.Models
{
    [Table("Mast")]
    public class Mast : EntityBase
    {
        [Index("INDEX_LAT")]
        [Column(TypeName = "decimal(18,6)")]
        public decimal Lat { get; set; }

        [Index("INDEX_LON")]
        [Column(TypeName = "decimal(18,6)")]
        public decimal Lon { get; set; }

    }
}
