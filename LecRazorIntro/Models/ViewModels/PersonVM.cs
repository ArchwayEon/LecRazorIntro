using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LecRazorIntro.Models.ViewModels
{
   public class PersonVM
   {
      [Required(ErrorMessage = "The name cannot be blank.")]
      public string Name { get; set; }

      [StringLength(20, MinimumLength = 3, ErrorMessage = "Must be at least 3 and at most 20 characters!")]
      public string Occupation { get; set; }

      [Range(18, 100)]
      public int Age { get; set; }

      [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Invalid Phone Number!")]
      public string Phone { get; set; }

      [Display(Name = "Date of Birth")]
      [DataType(DataType.Date)]
      public DateTime DateOfBirth { get; set; }

      [DataType(DataType.Currency)]
      public decimal PayPerHour { get; set; }

      [EmailAddress(ErrorMessage = "Invalid Email")]
      public string Email { get; set; }
   }

}
