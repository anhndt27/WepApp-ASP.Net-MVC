using System.ComponentModel.DataAnnotations;

namespace WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;

public class EnrollmentCreateDto
{
    [Key]
    public int? CourseId { get; set; }
    public int? StudentId { get; set; }
}