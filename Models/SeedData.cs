using Microsoft.EntityFrameworkCore;

namespace final_vjwill77.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Participants.Any())
        {
            return;
        }

       // Add Participants, Courses, and ParticipantCourses below
List<Participant> participants = new List<Participant>
{
    new Participant { FirstName = "John", LastName = "Doe", ShirtSize = "L", Gender = "Male", Email = "jdoe@gmail.com", Age = 25 },
    new Participant { FirstName = "Jane", LastName = "Smith", ShirtSize = "S", Gender = "Female", Email = "jsmith@gmail.com", Age = 36  },
    new Participant { FirstName = "Michael", LastName = "Johnson", ShirtSize = "XL", Gender = "Male", Email = "mjohnson@gmail.com", Age = 43  },
    new Participant { FirstName = "Emily", LastName = "Davis", ShirtSize = "M", Gender = "Female", Email = "edavis@gmail.com", Age = 22  },
    new Participant { FirstName = "Daniel", LastName = "Garcia", ShirtSize = "L", Gender = "Male", Email = "dgarcia@gmail.com", Age = 33  },
    new Participant { FirstName = "Sophia", LastName = "Martinez", ShirtSize = "S", Gender = "Female", Email = "smartinez@gmail.com", Age = 45  },
    new Participant { FirstName = "William", LastName = "Rodriguez", ShirtSize = "M", Gender = "Male", Email = "wrodriguez@gmail.com", Age = 50  },
    new Participant { FirstName = "Olivia", LastName = "Wilson", ShirtSize = "L", Gender = "Female", Email = "owilson@gmail.com", Age = 52  },
    new Participant { FirstName = "James", LastName = "Anderson", ShirtSize = "XL", Gender = "Male", Email = "janderson@gmail.com", Age = 29  },
    new Participant { FirstName = "Isabella", LastName = "Thomas", ShirtSize = "S", Gender = "Female", Email = "ithomas@gmail.com", Age = 38  },
    new Participant { FirstName = "Alexander", LastName = "Lee", ShirtSize = "L", Gender = "Male", Email = "alee@gmail.com", Age = 22 },
    new Participant { FirstName = "Mia", LastName = "Perez", ShirtSize = "S", Gender = "Female", Email = "mperez@gmail.com", Age = 45  },
    new Participant { FirstName = "Benjamin", LastName = "Taylor", ShirtSize = "M", Gender = "Male", Email = "btaylor@gmail.com", Age = 55  },
    new Participant { FirstName = "Charlotte", LastName = "Moore", ShirtSize = "XL", Gender = "Female", Email = "cmoore@gmail.com", Age = 40  },
    new Participant { FirstName = "Ethan", LastName = "Jackson", ShirtSize = "L", Gender = "Male", Email = "ejackson@gmail.com", Age = 29  },
    new Participant { FirstName = "Amelia", LastName = "Martin", ShirtSize = "S", Gender = "Female", Email = "amartin@gmail.com", Age = 30  },
    new Participant { FirstName = "Logan", LastName = "Harris", ShirtSize = "M", Gender = "Male", Email = "lharris@gmail.com", Age = 49  },
    new Participant { FirstName = "Ava", LastName = "Clark", ShirtSize = "S", Gender = "Female", Email = "aclark@gmail.com", Age = 52 },
    new Participant { FirstName = "Mason", LastName = "Lewis", ShirtSize = "L", Gender = "Male", Email = "mlewis@gmail.com", Age = 26  },
    new Participant { FirstName = "Harper", LastName = "Walker", ShirtSize = "XL", Gender = "Female", Email = "hwalker@gmail.com", Age = 32  },
    new Participant { FirstName = "Elijah", LastName = "Hall", ShirtSize = "L", Gender = "Male", Email = "ehall@gmail.com", Age = 41  },
    new Participant { FirstName = "Ella", LastName = "Allen", ShirtSize = "M", Gender = "Female", Email = "eallen@gmail.com", Age = 27  }
    
};
context.AddRange(participants);
context.SaveChanges();

List<Course> courses = new List<Course>
{
    new Course { Name = "Wildspire 25K", Description = "Ridge Loop 25K" },
    new Course { Name = "Wildspire 50K", Description = "Highline Ultra 50K" },
    new Course { Name = "Wildspire 50 Mile", Description = "Thunder Basin 50M" }
    
};
context.AddRange(courses);
context.SaveChanges();

List<ParticipantCourse> participantCourses = new List<ParticipantCourse>
{
    
    new ParticipantCourse { ParticipantID = 1, CourseID = 1 },
    
    new ParticipantCourse { ParticipantID = 2, CourseID = 1 },
    
    new ParticipantCourse { ParticipantID = 3, CourseID = 2 },

    new ParticipantCourse { ParticipantID = 4, CourseID = 3 },

    new ParticipantCourse { ParticipantID = 5, CourseID = 2 },

    new ParticipantCourse { ParticipantID = 6, CourseID = 1 },
    
    new ParticipantCourse { ParticipantID = 7, CourseID = 2 },
    
    new ParticipantCourse { ParticipantID = 8, CourseID = 3 },

    new ParticipantCourse { ParticipantID = 9, CourseID = 3 },

    new ParticipantCourse { ParticipantID = 10, CourseID = 1 },

    new ParticipantCourse { ParticipantID = 11, CourseID = 1 },
    
    new ParticipantCourse { ParticipantID = 12, CourseID = 1 },
    
    new ParticipantCourse { ParticipantID = 13, CourseID = 2 },

    new ParticipantCourse { ParticipantID = 14, CourseID = 3 },

    new ParticipantCourse { ParticipantID = 15, CourseID = 2 },

    new ParticipantCourse { ParticipantID = 16, CourseID = 1 },
    
    new ParticipantCourse { ParticipantID = 17, CourseID = 2 },
    
    new ParticipantCourse { ParticipantID = 18, CourseID = 3 },

    new ParticipantCourse { ParticipantID = 19, CourseID = 3 },

    new ParticipantCourse { ParticipantID = 20, CourseID = 1 },

    new ParticipantCourse { ParticipantID = 21, CourseID = 1 },

    new ParticipantCourse { ParticipantID = 22, CourseID = 1 }
    };
context.AddRange(participantCourses);
context.SaveChanges();
    }
}