

namespace TasksFollowupAPI
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Body { get; set; }

        public ICollection<Task> Tasks { get; set; }
        public ICollection<SubjectAttachment> Attachments { get; set; }
    }
}
