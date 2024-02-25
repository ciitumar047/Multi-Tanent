using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class State
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Abbreviation { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public long CreatedByUserId { get; set; }

        [Required]
        public DateTime LastUpdatedOn { get; set; }

        [Required]
        public long LastUpdatedByUserId { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
