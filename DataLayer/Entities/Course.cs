using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace WebAppFinal.DataLayer.Entities;

public class Course
{
    [Key]
    [Required]
    public int CourseID { get; set; }
    public string Title { get; set; }
    public double Credits { get; set; }
    public virtual ICollection<Enrollment> Enrollments { get; set; }
}