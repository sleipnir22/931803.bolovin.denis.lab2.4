using System.ComponentModel.DataAnnotations;

namespace Lab4.ViewModels {
    public class ResetStep1Model {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
