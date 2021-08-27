using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter A Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Specify If You'll Attend")]
        public bool? WillAttend { get; set; }
    }
}
