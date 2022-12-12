namespace Assessment9.Models
{
    public class Book
    {
        public string name { get; set; }
        public List<string> authors { get; set; }
        public int numberOfPages { get; set; }
        public string publisher { get; set; }
        public DateTime released { get; set; }
    }
}
