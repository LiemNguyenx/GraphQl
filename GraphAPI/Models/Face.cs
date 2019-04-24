using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Models
{
    public class Face
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Img { get; set; }
        public string Location { get; set; }
        public DateTime LastFound { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ModifyDate { get; set; }
        public long OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
