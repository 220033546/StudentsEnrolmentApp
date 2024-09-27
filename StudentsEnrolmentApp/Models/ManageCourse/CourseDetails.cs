using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentsEnrolmentApp.Models.ManageCourse
{
    public class CourseDetails
    {
        public int Id { get; set; }
        public required string FirstName {get;set;}
        public required string LastName {get;set;}
        public required string PhoneNumber { get; set; }
        public required string Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public required string EmailAddress { get; set; }
        public DateOnly RegistrationDate { get;set;}
        public required string EnrolProgram { get;set;}
        public required string StudentNumber { get;set;}
    }
}
