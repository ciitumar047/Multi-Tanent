using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class TenantCreditCard
    {
        [Key]
        public long Id { get; set; }

        public long TenantId { get; set; }

        public int CreditCardType { get; set; }

        [Required]
        [StringLength(200)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string CreditCardExpireMonth { get; set; }

        [Required]
        [StringLength(20)]
        public string CreditCardExpireYear { get; set; }

        [Required]
        [StringLength(200)]
        public string CVVNumber { get; set; }

        [Required]
        [StringLength(350)]
        public string NameOnCard { get; set; }

        [StringLength(500)]
        public string AddressOnCard { get; set; }

        [StringLength(200)]
        public string CardCity { get; set; }

        [StringLength(50)]
        public string CardZip { get; set; }

        public int? CreditCardStateId { get; set; }

        [StringLength(500)]
        public string CardNotes { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public long CreatedByUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public DateTime? LastUpdatedOn { get; set; }

        public int OfficeId { get; set; }

        [StringLength(250)]
        public string OfficeName { get; set; }

        [StringLength(150)]
        public string CustomerProfileID { get; set; }

        [StringLength(150)]
        public string CustomerPaymentProfileID { get; set; }
        public Tenant Tenant { get; set; }
    }
}
