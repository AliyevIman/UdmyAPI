using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCourseDal :EFEntityRepositoryBase<UdMyDbContext,Course>,ICourseDal
    {
        public void AddWithLesson(CourseDTO courseDTO)
        {
            using var contex = new UdMyDbContext();
            Course course1 = new Course()
            {
                Name = courseDTO.Name,
                Summary = courseDTO.Summary,
                Description = courseDTO.Description,
                PhotoUrl = courseDTO.PhotoUrl,
                Discount = courseDTO.Discount,
                Reyting = courseDTO.Reyting,
                TrailerUrl = courseDTO.TrailerUrl,
                CategoryId = courseDTO.CategoryId,
                InstructorId = courseDTO.InstructorId,
                Lessons = new List<Lesson>(),
                CourseSpecifactions = new List<CourseSpecifaction>(),


            };
            if (courseDTO.Lessons != null && courseDTO.Lessons.Count > 0)
            {
                course1.Lessons.AddRange(
                    courseDTO.Lessons.Select(les => new Lesson
                    {
                        Name = les.Name
                    }));

            }
            if(courseDTO.SpecifactionDTO !=null && courseDTO.SpecifactionDTO.Count > 0)
            {

            var specifactionList=    courseDTO.SpecifactionDTO.Select(c => new Specifaction { Icon = c.Icon, Value = c.Value }).ToList();
                //courseDTO.CourseSpecifactions.AddRange(specifactionList.Select(c=>new CourseSpecifactionDTO { CourseId = course1.Id,SpecifactionId = specifactionList}));

            }
            contex.Courses.Add(course1);
            contex.SaveChanges();
            
        }

    }
    
}
