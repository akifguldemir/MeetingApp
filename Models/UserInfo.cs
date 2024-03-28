using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        [MinLength(11, ErrorMessage = "Telefon en az 11 eleman içermelidir.")]
        public string? Phone { get; set; } 

        [Required(ErrorMessage = "Email alanı zorunlu")]
        [EmailAddress]
        public string? Email { get; set; } 

        [Required]
        public bool WillAttend { get; set; } 

    }
}