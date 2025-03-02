using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Entities
{
    class Instructor
    {

        /*Using Mapiing => DataAnnotations*/
        [Key]
        public int ID { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        public decimal salary { get; set; }

        public decimal Bonus { get; set; }

        public decimal HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        [InverseProperty(nameof(Entities.Department.Instructors))]

        public Department Department { get; set; }
        [InverseProperty(nameof(Entities.Department.Manger ))]

        public Department? Mange{ get; set; }

        public ICollection<Course_Inst> Courses { get; set; } = new HashSet<Course_Inst>();
            
    }
}
