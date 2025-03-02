using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Entities
{
    class Department
    {
        // Fluent API Mapping
        public int ID { get; set; }
        public string Name { get; set; }


        public DateOnly HiringDate { get; set; }
        [ForeignKey("Manger")]
        public int Ins_ID { get; set; }
        [InverseProperty(nameof(Instructor.Mange))]

        public Instructor Manger { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

    }
}
