using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.StudentQueryDto;

public static class StudentListDTOSelect
{
    public static IQueryable<StudentDTO> MapStudentDTO(this IQueryable<Student> students)
    {
        return students.Select(s => new StudentDTO
        {
            ID = s.ID,
            Name = s.Name,
            Code = s.Code,
            Cource = string.Join(", ", s.Enrollments.Select(e => e.Course.Title))
        });
    }
}