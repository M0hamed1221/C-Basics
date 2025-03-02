using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Entities
{
    class Student
    {
        public int ID { get; set; }

        public string FName { get; set; }

        public string? LName { get; set; }

        public string? Address { get; set; }
        public int Age { get; set; }
        [ForeignKey("Department")]

        public int? Dep_ID { get; set; }
        public Department? Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();


    }
}
