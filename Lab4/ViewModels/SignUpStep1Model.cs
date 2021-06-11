using System;
using System.ComponentModel.DataAnnotations;
using Lab4.Models;

namespace Lab4.ViewModels {
    public class SignUpStep1Model {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; } = DateTime.Now;

        [Required]
        public Gender Gender { get; set; }
    }
}
