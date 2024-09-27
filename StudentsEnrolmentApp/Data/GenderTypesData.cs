using StudentsEnrolmentApp.Models.ManageCourse;

namespace StudentsEnrolmentApp.Data
{
    public class GenderTypesData
    {
        private readonly List<GenderTypes> genderTypes =
        [
            new(){
                Id = 1,
                Name = "Female"
            },
            new(){
                Id = 1,
                Name = "Male"
            },

        ];

        public GenderTypes[] GetGenderTypes() => [.. genderTypes];
    }
}
