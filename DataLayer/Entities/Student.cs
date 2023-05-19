using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace WebAppFinal.DataLayer.Entities
{
    public class Student
    {
        public int ID { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [DisplayName("Full Name")]
        public string Name { get; set; }



        [Required]
        [DisplayName("Code")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        public string Code { get; set; }
        

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
