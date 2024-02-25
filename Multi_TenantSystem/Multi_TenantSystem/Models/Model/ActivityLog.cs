using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class ActivityLog
    {
        [Key]
        public int Id { get; set; }
        public int ActivityLogTypeId { get; set; }
        public string Data { get; set; }
        public long? EntityId { get; set; }
        public string EntityName { get; set; }
        public string OperationType { get; set; }
        public long CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }

        [ForeignKey("ActivityLogTypeId")]
        public virtual ActivityLogType ActivityLogType { get; set; }
    }
}
