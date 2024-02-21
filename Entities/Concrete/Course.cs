using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course: IEntity
    {
        public int CourtseId;
        public string CourseName;
        public string CourseDescription;

    }
}
