namespace Multi_TenantSystem.Models.Model
{
    public class MailLog
    {
        public long Id { get; set; }
        public long? TenantId { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        public int Type { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedByUserId { get; set; }
        public long? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
