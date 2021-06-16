using System;

namespace Lab4.Models {
    public class User {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public enum Gender {
        Male,
        Female
    }
}
