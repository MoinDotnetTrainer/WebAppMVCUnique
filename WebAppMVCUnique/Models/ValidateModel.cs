using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVCUnique.Models
{
    public class ValidateModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required")] // data annoation  which chks null values
        [RegularExpression("^[A-Za-z]+$")]
        public string Name { get; set; }  // if not supplied , error ,Name required

        [Required]
        [EmailAddress] // valiate correct email pattern
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [NotMapped]  // will not be created in db
        [Compare("Password")]
        public string ConfirmPassword { get; set; } // not nec
        [Required]
        [RegularExpression("^[0-9]{10}$")]

        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Dept { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
        [Range(18, 50)]
        public int Age { get; set; }


    }
}
