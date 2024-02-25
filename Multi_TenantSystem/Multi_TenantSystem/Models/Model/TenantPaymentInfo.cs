using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class TenantPaymentInfo
    {
        [Key]
        public long Id { get; set; }

        public long TenantId { get; set; }

        public int? PaymentMethodId { get; set; }

        [StringLength(50)]
        public string CheckNo { get; set; }

        public long? TenantCreditCardId { get; set; }

        [StringLength(4000)]
        public string AuthorizationTransactionId { get; set; }

        [StringLength(4000)]
        public string AuthorizationTransactionCode { get; set; }

        [StringLength(4000)]
        public string AuthorizationTransactionResult { get; set; }

        [StringLength(4000)]
        public string AuthorizationTransactionError { get; set; }

        [StringLength(4000)]
        public string CaptureTransactionId { get; set; }

        [StringLength(4000)]
        public string CaptureTransactionResult { get; set; }

        [StringLength(4000)]
        public string SubscriptionTransactionID { get; set; }

        [Required]
        public decimal AmountPaid { get; set; }

        [Required]
        public DateTime LastBillingDate { get; set; }

        public DateTime? NextBillingDate { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public bool Success { get; set; }

        public bool? Deleted { get; set; }

        public long? CreatedByUserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? LastUpdatedByUserId { get; set; }

        public DateTime? LastUpdatedOn { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Request { get; set; }

        [StringLength(1000)]
        public string ShortError { get; set; }

        public int OfficeId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
