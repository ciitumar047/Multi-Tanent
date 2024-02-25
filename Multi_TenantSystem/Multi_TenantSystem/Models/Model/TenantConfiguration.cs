using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class TenantConfiguration
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string CompanyURL { get; set; }

        [Required]
        [StringLength(50)]
        public string DataBaseName { get; set; }

        [Required]
        [StringLength(50)]
        public string DBServerName { get; set; }

        [Required]
        [StringLength(50)]
        public string DBUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string DBPassword { get; set; }

        [StringLength(50)]
        public string AdminEmail { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? TenantLoginDate { get; set; }

        public bool Trial { get; set; }

        [StringLength(100)]
        public string ProductPlan { get; set; }

        public bool Deleted { get; set; }

        public long? CreatedByUserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public DateTime? LastUpdatedOn { get; set; }
        public long TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
