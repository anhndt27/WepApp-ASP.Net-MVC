using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.Reponse
{
    public class StudentListCombinedDTO
    {
        public SortFilterPageOptions sortFiltePageData { get; private set; }
        public IEnumerable<StudentDTO> StudentList { get; private set; }
        public StudentListCombinedDTO(SortFilterPageOptions option, IEnumerable<StudentDTO> studentList)
        {
            sortFiltePageData = option;
            StudentList = studentList;
        }
    }
}
