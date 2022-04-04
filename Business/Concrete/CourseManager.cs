using Business.Abstract;
using DataAccess.Abstract;
using Entites;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseSpecifactioManager :ICourseManager
    {
        private readonly ICourseDal _coursedal;

        public CourseSpecifactioManager(ICourseDal coursedal)
        {
            _coursedal = coursedal;
        }

        public void Add(CourseDTO courseDTO)
        {
            
            //if(courseDTO.CourseSpecifactions != null && courseDTO.CourseSpecifactions.Count > 0)
            //{
            //    course1.CourseSpecifactions.AddRange(
            //                        courseDTO.CourseSpecifactions.Select(les => new CourseSpecifaction { CourseId = les.CourseId }));
            //}
            _coursedal.AddWithLesson(courseDTO);
        }

        public List<Course> GetAll()
        {
            return _coursedal.GetAll();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CourseDTO course)
        {
            throw new NotImplementedException();
        }
    }
}
