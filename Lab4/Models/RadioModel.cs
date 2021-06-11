using System.ComponentModel.DataAnnotations;

namespace Lab4.Models {
    public class RadioModel {
        [Required]
        public Month Month { get; set; }
    }
}
