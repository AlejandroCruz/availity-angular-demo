using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AvailityAPI.Models
{
    public class LoginDetails
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
        public int NpiNumber { get; set; }
        [MaxLength(15)]
        public int PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(256)")]
        public string Email { get; set; }
    }
}
