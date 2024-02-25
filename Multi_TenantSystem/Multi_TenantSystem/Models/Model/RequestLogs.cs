using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class RequestLogs
    {
        [Key]
        public long Id { get; set; }

        public long? TenantId { get; set; }

        [StringLength(100)]
        public string DataBase_Name { get; set; }

        [StringLength(500)]
        public string URL { get; set; }

        [StringLength(50)]
        public string RequestIPAddress { get; set; }

        public string RequestLog { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? CreatedByUserId { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public DateTime? LastUpdatedOn { get; set; }
    }
}
