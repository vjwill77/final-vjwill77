using System.ComponentModel.DataAnnotations;

namespace final_vjwill77.Models;

public class Participant
{
    public int ParticipantID {get; set;} // Primary Key

    [Display(Name = "First Name")]
    public string FirstName {get; set;} = string.Empty;
    
    [Display(Name = "Last Name")]
    public string LastName {get; set;} = string.Empty;

    [Display(Name = "Shirt Size")]
    public string ShirtSize {get; set;} = string.Empty;

    public string Gender {get; set;} = string.Empty;

    [EmailAddress]
    public string Email {get; set;} = string.Empty;

    public int Age {get; set;}

    // This property is optional (?) because Participants can exist without being in a course. Courses can exist without participants.
    [Display(Name = "Registered Course")]
    public List<ParticipantCourse>? ParticipantCourses {get; set;} = default!; // Navigation property.
}