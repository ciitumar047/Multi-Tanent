namespace Multi_TenantSystem.Models.Model
{
    public class MessageTemplate
    {
        public long Id { get; set; }
        public string MessageName { get; set; }
        public string BCCEmailAddresses { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool Deleted { get; set; }
        public long? CreatedByUserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
