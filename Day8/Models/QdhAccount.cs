using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Day8.Models
{
    public class QdhAccount
    {
        public int ID { get; set; }

        [
        Display(Name = "QdhAccount"),
        Required(ErrorMessage = "Please enter your full name"),
        MinLength(3, ErrorMessage = "Full name must be at least 3 characters long"),
        MaxLength(50, ErrorMessage = "Full name must not exceed 50 characters"),
        ]


        public string QdhFullname { get; set; }
        [Display(Name = "QdhEmail")]
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string QdhEmail { get; set; }
        [Display(Name = "QdhPhone")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "CheckPhone", controller: "QdhAccount")]


        [Required(ErrorMessage = "Please enter your phone number")]
        public string QdhPhone { get; set; }
        [Display(Name = "QdhAddress")]
        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100, ErrorMessage = "Address must not exceed 100 characters")]

        public string QdhAddress { get; set; }
        [Display(Name = "QdhAvatar")]
        public string QdhAvatar { get; set; }
        [Display(Name = "QdhBirthday")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter your date of birth")]
        public DateTime QdhBirthday { get; set; }
        [Display(Name = "QdhGender")]
        public string QdhGender { get; set; }
        [Display(Name = "QdhPassword")]
        [DataType(DataType.Password)]
        public string QdhPassword { get; set; }
        [Display(Name = "QdhLink")]
        [Required(ErrorMessage = "Please enter your social media link")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string QdhLink { get; set; }
    }

}

