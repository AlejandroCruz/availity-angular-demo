using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvailityAPI.Domain.Entities
{
    [Table("LoginDetails", Schema = "dbo")]
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
        public string NpiNumber { get; set; } = null;

        [Column(TypeName = "nvarchar(256)")]
        public string PhoneNumber { get; set; } = null;

        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string Email { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
