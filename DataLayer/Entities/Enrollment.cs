namespace WebAppFinal.DataLayer.Entities
{
    public enum Order
    {
        A,
        B,
        C,
        D
    }
    public class Enrollment 
    {
        public string? Order { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
