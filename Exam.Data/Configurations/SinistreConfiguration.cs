using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Configurations
{
    public class SinistreConfiguration : EntityTypeConfiguration<Sinistre>
    {
        public SinistreConfiguration()
        {
            //One to many relation between sinistre et contrat
            HasRequired<Contrat>(g => g.Contrat)
                .WithMany(g => g.Sinistres)
                .HasForeignKey<int>(g => g.ContratId);

            ////One to Many Relation between Sinistre et Garage (UserAccount)
            //HasRequired<UserAccount>(e => e.GarageExperts)
            //    .WithMany(e => e.Sinistres)
            //    .HasForeignKey<int>(e => e.UserAccountId);

            //Many to One Relation between Sinistre et Bon de sortie
            HasMany<BonDeSortie>(s => s.BonsDeSorties)
                .WithRequired(s => s.Sinistre)
                .HasForeignKey(s => s.SinistreId);
            //Many to One Relation between Sinistre et Facture
            HasMany<Facture>(s => s.Factures)
                .WithRequired(s => s.Sinistre)
                .HasForeignKey(s => s.SinistreId);

            //Many to One Relation between Sinistre et Confirmation
            HasMany<Confirmation>(s => s.Confirmations)
                .WithRequired(s => s.Sinistre)
                .HasForeignKey(s => s.SinistreId);

            HasMany<UserAccount>(u => u.GarageExperts).
                WithMany(s => s.Sinistres).Map(m =>
                {
                    m.MapLeftKey("SinistreId");  // because it is the "left" column, isn't it?
                    m.MapRightKey("UserId"); // because it is the "right" column, isn't it?
                    m.ToTable("UsersSinistres");
                });

        }
    }
}
