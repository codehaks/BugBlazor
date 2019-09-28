namespace BugBlazor.Models
{
    public class Bug
    {
        public Bug()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public StateType State { get; set; }
    }
}