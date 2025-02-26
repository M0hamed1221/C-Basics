using System;
using System.Collections.Generic;
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

        public int Ins_ID { get; set; }

        public DateOnly HiringDate { get; set; }



    }
}
