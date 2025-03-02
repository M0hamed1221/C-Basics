using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Entities
{
    class Topic
    {
        /*Using Mapiing => Convention-based Mapping*/

        public int ID { get; set; }

        public string Name { get; set; }


        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
