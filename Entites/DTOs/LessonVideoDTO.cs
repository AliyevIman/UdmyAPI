using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class LessonVideoDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string VideoURl { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public int LessonId { get; set; }
    }
}
