namespace TasksFollowupAPI
{
    using Microsoft.EntityFrameworkCore;
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Task> Tasks { get; set; }
            public DbSet<SubjectAttachment> SubjectAttachments { get; set; }
        }

}
