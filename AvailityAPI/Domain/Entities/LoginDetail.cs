using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvailityAPI.Domain.Entities
{
    public class LoginDetail
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string FirstName { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string LastName { get; set; }
        
        public int NpiNumber { get; set; }
        
        public int PhoneNumber { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string Email { get; set; }
    }
}
