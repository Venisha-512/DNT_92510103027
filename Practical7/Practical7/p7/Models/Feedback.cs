using System.ComponentModel.DataAnnotations;

namespace p7.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Enter a valid 10-digit mobile number")]
        [Display(Name = "Mobile Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a subject")]
        public string Subject { get; set; }

        [Range(1, 5, ErrorMessage = "Please select a rating from 1 to 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Comments must be between 10 and 300 characters")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        [Display(Name = "Send me a copy of this feedback")]
        public bool WantsCopy { get; set; }

        public DateTime SubmittedOn { get; set; }
    }
}
