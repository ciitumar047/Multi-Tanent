using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string SettingName { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public long? CreatedByUserId { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public DateTime? LastUpdatedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool Deleted { get; set; }
    }
}
