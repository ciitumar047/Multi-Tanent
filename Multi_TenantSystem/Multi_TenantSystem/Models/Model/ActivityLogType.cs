using System.ComponentModel.DataAnnotations;

namespace Multi_TenantSystem.Models.Model
{
    public class ActivityLogType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SystemKeyword { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}
