namespace Assessment9.Models
{
    public class House
    {
        public string name { get; set; }
        public string region { get; set; }
        public string words { get; set; }
        public string currentLord { get; set; } 
        public Character? currentLordChar { get; set; } 
        public string founder { get; set; }
        public List<string> swornMembers { get; set; }
        public List<Character> character { get; set; } = new List<Character>();
    }
}
