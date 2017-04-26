using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UnitTestMVCApp.Models
{
    public class Subscriber
    {
        [Required]
        [StringLength(35)]
        public string  Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Birthday { get; set; }
    }
}