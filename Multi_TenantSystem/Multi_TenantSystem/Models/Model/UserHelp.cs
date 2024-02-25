namespace Multi_TenantSystem.Models.Model
{
    public class UserHelp
    {
        public int Id { get; set; }
        public string HelpTitle { get; set; }
        public string HelpDescription { get; set; }
        public string PageUrl { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? DisplayOrder { get; set; }
        public long CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? UpdatedByUserId { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
