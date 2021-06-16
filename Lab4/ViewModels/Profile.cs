using System;
using System.ComponentModel.DataAnnotations;
using Lab4.Models;

namespace Lab4.ViewModels {
    public class Profile {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd MMMM yyyy}")]
        public DateTime BirthDay { get; set; }

        public Gender Gender { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
