using System.ComponentModel.DataAnnotations;

namespace AspNetIntro2.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        [Range(1, 120, ErrorMessage = "Age must be greater than 0")]
        public int Age { get; set; }

    }
}
