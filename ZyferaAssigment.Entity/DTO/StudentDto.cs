using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyferaAssigment.Entity.DTO
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StdNumber { get; set; }
        public List<GradeDto> Grades { get; set; }
    }
}
