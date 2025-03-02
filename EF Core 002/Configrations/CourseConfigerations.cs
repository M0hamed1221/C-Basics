using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_002.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_002.Configrations
{
    class CourseConfigerations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasMany(c => c.Instractors)
                   .WithOne(ci=>ci.Course)
                   .HasForeignKey(ci => ci.Inst_ID);
            builder.HasMany(c => c.Stud_Courses)
                   .WithOne(sc=>sc.Course)
                   .HasForeignKey(sc => sc.Course_ID);
             
        }
    }

}
