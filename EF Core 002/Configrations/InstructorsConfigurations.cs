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
    class InstructorsConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasMany(i => i.Courses)
                .WithOne(ci => ci.Instructor)
                .HasForeignKey(ci => ci.Inst_ID);
            builder.HasOne(i => i.Mange)
                .WithOne(D => D.Manger)
                .OnDelete(DeleteBehavior.SetNull);
           

        }
    }
}
