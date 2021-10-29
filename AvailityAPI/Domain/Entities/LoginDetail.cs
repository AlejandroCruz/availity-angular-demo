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

        [Column(TypeName = "nvarchar(256)")]
        public string NpiNumber { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string PhoneNumber { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string Email { get; set; }
    }
}
