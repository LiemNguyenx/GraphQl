using System;
using System.ComponentModel.DataAnnotations;

namespace GraphAPI.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
            CreatedAt = Int64.MaxValue;
            CreatedBy = "99999999-9999-9999-9999-999999999999";
            UpdatedAt = Int64.MaxValue;
            IsDeleted = false;
        }

        [Key]
        public Guid Id { get; set; }

        [MaxLength(1000)]
        public string CreatedBy { get; set; }
        public long CreatedAt { get; set; }

        [MaxLength(1000)]
        public string UpdatedBy { get; set; }
        public long UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class EntityBaseNotId
    {
        public EntityBaseNotId()
        {
            CreatedAt = Int64.MaxValue;
            CreatedBy = "99999999-9999-9999-9999-999999999999";
            UpdatedAt = Int64.MaxValue;
            IsDeleted = false;
        }

        [MaxLength(1000)]
        public string CreatedBy { get; set; }
        public long CreatedAt { get; set; }

        [MaxLength(1000)]
        public string UpdatedBy { get; set; }
        public long UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
