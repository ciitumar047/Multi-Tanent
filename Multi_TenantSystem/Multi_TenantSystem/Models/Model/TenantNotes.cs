using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class TenantNotes
    {
        [Key]
        public long Id { get; set; }

        public long TenantId { get; set; }

        [Required]
        [StringLength(1000)]
        public string Notes { get; set; }

        public DateTime CreatedOn { get; set; }

        public long CreatedByUserId { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public long? LastUpdatedByUserId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
