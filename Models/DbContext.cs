using Microsoft.EntityFrameworkCore;

namespace final_vjwill77.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    // Needed for Many-to-Many association entity
    // StudentCourse entity has 2 attributes as the primary key.
    // This code tells EF Core that StudentID and CourseID combine for the primary key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ParticipantCourse>().HasKey(p => new {p.CourseID, p.ParticipantID});
    }

    public DbSet<Participant> Participants {get; set;}
    public DbSet<Course> Courses {get; set;}
    public DbSet<ParticipantCourse> ParticipantCourses {get; set;}
}