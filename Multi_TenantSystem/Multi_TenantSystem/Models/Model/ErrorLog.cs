namespace Multi_TenantSystem.Models.Model
{
    public class ErrorLog
    {public long Id { get; set; }
        public string ShortMessage { get; set; }
        public string FullMessage { get; set; }
        public string IpAddress { get; set; }
        public long? UserId { get; set; }
        public string PageUrl { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedByUserId { get; set; }
        public long? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
