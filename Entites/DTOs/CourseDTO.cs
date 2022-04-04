using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class CourseDTO
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public decimal? Discount { get; set; }
        public decimal? Reyting { get; set; }
        public string? TrailerUrl { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public bool IsFeatured { get; set; }
        public decimal Price { get; set; }
        public List<LessonDTO>? Lessons { get; set; }

        public virtual List<CourseSpecifactionDTO>? CourseSpecifactions { get; set; }
        public virtual List<SpecifactionDTO>? SpecifactionDTO { get; set; }



    }
}
