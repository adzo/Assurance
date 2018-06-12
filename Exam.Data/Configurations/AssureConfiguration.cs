using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Configurations
{
    public class AssureConfiguration : EntityTypeConfiguration<Assure>
    {
        public AssureConfiguration()
        {
            //Many to One between Assuré et Reclamation
            HasMany<Reclamation>(s => s.Reclamations)
                .WithRequired(s => s.Assure)
                .HasForeignKey(s => s.AssureId);
        }
    }
}
