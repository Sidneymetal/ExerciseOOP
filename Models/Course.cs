using ExerBalta;
namespace ExerBalta.Models.Enums
{
    public class Course : Content
    {
        public Course(string title, string ulr) : base(title, ulr)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public List<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }        
    }
}