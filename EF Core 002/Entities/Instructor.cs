using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        public int Dept_ID { get; set; }

    }
}
