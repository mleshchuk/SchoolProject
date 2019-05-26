using System.Collections.Generic;
using System.Linq;


namespace School
{
    public class School
    {
        public List<Classroom> classrooms;
        public List<Pupil> pupils;

        public School()
        {
            List<Classroom> classrooms = new List<Classroom>();
            List<Pupil> pupils = new List<Pupil>();
        }

        public School(IEnumerable<Classroom> classrooms = null, IEnumerable<Pupil> pupils= null)
        {
            this.classrooms = classrooms == null ? new List<Classroom>() : classrooms.ToList();
            this.pupils = pupils == null ? new List<Pupil>() : pupils.ToList(); ;
        }
    }
}
