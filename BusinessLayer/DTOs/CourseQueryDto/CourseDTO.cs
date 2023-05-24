using System.Collections;

namespace WebAppFinal.DTOs.Reponse
{
    public class CourseDTO : IEnumerable
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public double Credits { get; set; }
        public string? Student { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
