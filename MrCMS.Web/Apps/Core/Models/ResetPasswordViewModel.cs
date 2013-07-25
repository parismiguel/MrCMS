using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MrCMS.Entities.People;

namespace MrCMS.Web.Apps.Core.Models
{
    public class ResetPasswordViewModel
    {
        public ResetPasswordViewModel()
        {
        }

        public ResetPasswordViewModel(Guid id, User user)
        {
            Id = id;
            Email = user.Email;
        }

        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Minimum length for password is {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match.")]
        public string ConfirmPassword { get; set; }
    }
}