﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Entities
{
    class Course_Inst
    {
       
        public int Inst_ID { get; set; }
       
        public int Course_ID { get; set; }
        public int Evaluate { get; set; }

        public Instructor Instructor { get; set; } 

        public Course Course { get; set; } 
    }
}
