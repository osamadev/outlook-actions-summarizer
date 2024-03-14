

namespace TasksFollowupAPI
{
    public class SubjectAttachment
    {
        public int Id { get; set; }
        public string AttachmentName { get; set; }
        public byte[] Content { get; set; }
        public int SubjectId { get; set; }
    }
}
