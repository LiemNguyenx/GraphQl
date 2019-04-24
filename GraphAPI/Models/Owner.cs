using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Models
{
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastFound { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ModifyDate { get; set; }
        public List<Face> Faces { get; set; }
        public List<Plate> Plates { get; set; }
    }
}
