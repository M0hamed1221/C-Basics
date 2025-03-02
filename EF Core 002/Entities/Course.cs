using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Entities
{
    class Course

    {
        /*Using Mapiing => Fluent API Mapping*/

        public int ID { get; set; }

        public int Duration { get; set; }
         
        public string Name { get; set; }

        public string? Description { get; set; }
        [ForeignKey("Topic")]
        public int? Top_ID { get; set; }

        public Topic Topic { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();



        public ICollection<Course_Inst> Instractors { get; set; } = new HashSet<Course_Inst>();

    }
}
