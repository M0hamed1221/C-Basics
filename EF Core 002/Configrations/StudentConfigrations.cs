using EF_Core_002.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_002.Configrations
{
    class StudentConfigrations : IEntityTypeConfiguration<Student>
    {
        void IEntityTypeConfiguration<Student>.Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany(s => s.Stud_Courses)
                .WithOne(sc=>sc.Students)
                .HasForeignKey(sc => sc.Stud_ID);
             

        }
    }
}
