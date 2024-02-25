using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class Prospect
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string JobTitle { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(500)]
        public string RequestDetails { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        [Required]
        public int Status { get; set; }

        public bool Deleted { get; set; }

        public long? CreatedByUserId { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? RequestDate { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public DateTime? LastUpdatedOn { get; set; }
    }
}
