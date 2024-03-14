

namespace TasksFollowupAPI
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SubjectId { get; set; }
        public string AssignedTo { get; set; }

    }
}
