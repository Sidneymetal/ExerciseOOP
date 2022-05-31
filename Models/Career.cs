using ExerBalta;
namespace ExerBalta.Models.Enums
{
    public class Career : Content
    {
        public Career(string title, string ulr) : base(title, ulr)
        {
            Items = new List<CareerItem>();
        }
        public List<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; //Expression Body        
    }
}