namespace Multi_TenantSystem.Models.Model
{
    public class User
    {
        public long Id { get; set; }
        public Guid UserGuid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public string Cell { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedByUserId { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public long LastUpdatedByUserId { get; set; }
    }
}
