using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class TenantOffice
    {
        [Key, Column(Order = 0)]
        public long TenantId { get; set; }

        [Key, Column(Order = 1)]
        public int ClientDBId { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
        [Required]
        public decimal PaymentAmount { get; set; }
        public Tenant Tenant { get; set; }
    }
}
