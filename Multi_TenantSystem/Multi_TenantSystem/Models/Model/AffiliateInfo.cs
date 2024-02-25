using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class AffiliateInfo
    {
        [Key]
        public long Id { get; set; }
        public DateTime? JoiningDate { get; set; }
        public long? ParentAffiliateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int StateId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? CommissionType { get; set; }
        public decimal TotalComission { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public long CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long LastUpdatedByUserId { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
