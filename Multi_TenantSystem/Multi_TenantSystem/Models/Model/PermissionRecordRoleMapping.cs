using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Multi_TenantSystem.Models.Model
{
    public class PermissionRecordRoleMapping
    {
        [ForeignKey("PermissionRecord")]
        public int PermissionRecord_Id { get; set; }

        [ForeignKey("Role")]
        public int Role_Id { get; set; }

        // Navigation properties
        public virtual PermissionRecord PermissionRecord { get; set; }
        public virtual Role Role { get; set; }
    }
}
