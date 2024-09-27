using StudentsEnrolmentApp.Models.ManageCourse;

namespace StudentsEnrolmentApp.Data
{
    public class CoursesData
    {
        private readonly List<CourseDetails> courseDetails =
        [
                new(){
                            Id = 1,
                            FirstName = "Lara",
                            LastName = "Fitzgerald",
                            PhoneNumber ="078788999",
                            Gender = "female",
                            BirthDate = new DateOnly(2002, 08,05),
                            EmailAddress = "At@gmail.com",
                            RegistrationDate = new DateOnly(2024, 03,15),
                            EnrolProgram = "Cloud Computing and Infrastructure",
                            StudentNumber = "24010010"
                    },
                    new(){
                            Id = 2,
                            FirstName = "Mike",
                            LastName = "Meyer",
                            PhoneNumber ="078788999",
                            Gender = "Male",
                            BirthDate = new DateOnly(1991, 03,17),
                            EmailAddress = "Microsoft Azure Fundamentals",
                            RegistrationDate = new DateOnly(2024, 01,22),
                            EnrolProgram = "Test",
                            StudentNumber = "24010020"
                    },
                    new(){
                            Id = 3,
                            FirstName = "Murphy ",
                            LastName = "Fraser",
                            PhoneNumber ="078788999",
                            Gender = "female",
                            BirthDate = new DateOnly(1999, 05,10),
                            EmailAddress = "Murphy@gmail.com",
                            RegistrationDate = new DateOnly(2024, 01,23),
                            EnrolProgram = "Business Intelligence",
                            StudentNumber = "24010030"
                    }

        ];


        private readonly GenderTypes[] genderTypes = new GenderTypesData().GetGenderTypes();
        private readonly CourseTypes[] courseTypes = new CourseTypesData().GetCourseTypes();


        public CourseDetails[] GetCourseDetails() => [.. courseDetails];

        public void  AddCourseDetails(CreateCourse cCourse)
        {
            //ArgumentException.ThrowIfNullOrWhiteSpace(cCourse.Id);
            var courseType = courseTypes.SingleOrDefault(courseType => courseType.Id == cCourse.Id);
            var genderType = genderTypes.SingleOrDefault(genderType => genderType.Id == cCourse.Id);

            ////if (courseType == null || genderType == null)
            ////{
                var courseDtls = new CourseDetails
                {
                    Id = courseDetails.Count + 1,
                    FirstName = cCourse.FirstName,
                    LastName = cCourse.LastName,
                    PhoneNumber = cCourse.PhoneNumber,
                    Gender = genderType.Name,
                    BirthDate = cCourse.BirthDate,
                    EmailAddress = cCourse.EmailAddress,
                    RegistrationDate = cCourse.RegistrationDate,
                    EnrolProgram = courseType.Name,
                    StudentNumber = cCourse.StudentNumber
                };

                courseDetails.Add(courseDtls);
            //} else {

            //}

        }

    }
}
