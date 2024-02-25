namespace Multi_TenantSystem.Models.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TwoLetterISOCode { get; set; }
        public string ThreeLetterISOCode { get; set; }
        public string NumericISOCode { get; set; }
        public string DialingCode { get; set; }
        public bool? Published { get; set; }
        public int? DisplayOrder { get; set; }
        public long? CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
