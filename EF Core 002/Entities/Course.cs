using System;
using System.Collections.Generic;
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

        public int? Top_ID { get; set; }



    }
}
