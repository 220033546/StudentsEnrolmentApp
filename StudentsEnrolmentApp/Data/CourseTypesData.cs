using StudentsEnrolmentApp.Models.ManageCourse;

namespace StudentsEnrolmentApp.Data

{
    public class CourseTypesData
    {
        private readonly List<CourseTypes> courseTypes =
        //private readonly CourseTypes[] courseTypes =
        [
             new()
             {
                Id = 1,
                Name = "Cloud Computing and Infrastructure"
             },
             new()
             {
                Id = 2,
                Name = "CompTIA Security+"
             },
             new()
             {
                Id = 3,
                Name = "Microsoft Azure Fundamentals"
             },
             new()
             {
                Id = 4,
                Name = "Business Intelligence"
             },
             new()
             {
                Id = 5,
                Name = "Software Testing and Quality Assurance"
             }
        ];

        public CourseTypes[] GetCourseTypes() => [.. courseTypes];
        //public CourseTypes[] GetCourseTypes() => courseTypes;

    }
}
