using System.ComponentModel.DataAnnotations;

namespace Site_Api.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(20)]
        public required string UserName { get; set; }
        [MaxLength(200)]
        public required string Password { get; set; }
    }
}
