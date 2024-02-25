using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public long? CreatedByUserId { get; set; }

        [Required]
        public DateTime LastUpdatedOn { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public string Description { get; set; }

        // Navigation property for PermissionRecordRoleMapping
        public virtual ICollection<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }
    }
}
