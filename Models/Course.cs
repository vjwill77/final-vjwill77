namespace final_vjwill77.Models;

public class Course
{
    public int CourseID {get; set;} // Primary Key
    public string Name {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;

}

public class ParticipantCourse
{
    public int CourseID {get; set;} // Composite Primary Key, Foreign Key 1
    public int ParticipantID {get; set;} // Composite Primary Key, Foreign Key 2
    public Participant Participant {get; set;} = default!; // Navigation Property
    public Course Course {get; set;} = default!; // Navigation Property

    // This property is optional (?) because Participants can exist without being in a course. Courses can exist without participants.
    public List<ParticipantCourse>? ParticipantCourses {get; set;} = default!; // Navigation property. A participant can be enrolled in many courses
}