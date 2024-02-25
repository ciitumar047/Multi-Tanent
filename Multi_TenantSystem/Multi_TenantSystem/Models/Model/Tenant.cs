using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Multi_TenantSystem.Models.Model
{
    public class Tenant
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Admin { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public bool Deleted { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        [Required]
        public int CountryId { get; set; }
        public long AffiliateId { get; set; }
        public string JobTitle { get; set; }
        public int AllowedTechnicians { get; set; }
        public int AllowedUsers { get; set; }
        public string CompanyName { get; set; }

        [Required]
        public decimal PaymentAmount { get; set; }
        public int CommissionType { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal Discount { get; set; }
        public string CouponCode { get; set; }
        public long CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long LastUpdatedByUserId { get; set; }
        public DateTime LastUpdatedOn { get; set; }

        [Required]
        public bool MultiOffice { get; set; }

        [Required]
        public bool MultiOfficePayment { get; set; }

        [Required]
        public bool MarketingEnabled { get; set; }
        public bool ReviewSMSEnabled { get; set; }
        public bool TwilioCallEnabled { get; set; }
        public bool ChatSMSEnabled { get; set; }
        public decimal CallMarkup { get; set; }
        public decimal ChatMarkup { get; set; }
        public decimal PurchaseMarkup { get; set; }
        public string Username { get; set; }
        public ICollection<TenantConfiguration> TenantConfiguration { get; set; }
        public ICollection<TenantCreditCard> TenantCredit { get; set; }
        public ICollection<TenantNotes> TenantNotes { get; set; }
        public ICollection<TenantOffice> TenantOffice { get; set; }
        public ICollection<TenantPaymentInfo> TenantPaymentInfo { get; set; }

    }
}
