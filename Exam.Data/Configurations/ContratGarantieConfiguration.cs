using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Configurations
{
    public class ContratGarantieConfiguration : EntityTypeConfiguration<ContratGarantie>
    {
        public ContratGarantieConfiguration()
        {
            //One to many relation between ContratGarantie et contrat
            HasRequired<Contrat>(g => g.Contrat)
                .WithMany(g => g.Garanties)
                .HasForeignKey<int>(g => g.ContratId);

            //One to many relation between ContratGarantie et Garentie
            HasRequired<Garantie>(g => g.Garantie)
                .WithMany(g => g.Contrats)
                .HasForeignKey<int>(g => g.GarantieId);
        }
    }
}
