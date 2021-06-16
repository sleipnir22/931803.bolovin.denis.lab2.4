using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_4.Models
{
    public class User
    {
        [Required(ErrorMessage = "Enter a FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter a LastName")]
        public string LastName { get; set; }

        [Required]
        public int Day { get; set; }

        [Required]
        public string Month { get; set; }

        [Required]
        public int Year { get; set; }

        [Required(ErrorMessage = "Check a Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Incorrect email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Mismatch Password")]
        public string ComparePassword { get; set; }

        public bool Remeber { get; set; }

        public string Code { get; set; }


        public User()
        {
            Code = "1234";
        }


        public void generatenewCode() 
        {
            Random rand = new Random();
            Code = "";
            for (int i = 0; i < 4; i++)
                Code += rand.Next(1,9);
        }
    }
}
