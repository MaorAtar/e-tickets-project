﻿using System.ComponentModel.DataAnnotations;

namespace eTicketsProject.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password address is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
