using System.Collections;
using Microsoft.EntityFrameworkCore.Update;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.Models;

public class ViewModel 
{
   public IEnumerable<CourseDTO> model1 { get; set; }
   public EnrollmentCreateDto model2 { get; set; }
  
}