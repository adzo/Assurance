using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Exam.Domain.Entities
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage ="Please confirm your password")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        public string Role { get; set; }

        
        //Navigation property
        public virtual ICollection<Sinistre> Sinistres { get; set; }
        public virtual Assure Assure { get; set; }

    }
}