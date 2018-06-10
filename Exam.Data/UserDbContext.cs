using Exam.Data.Configurations;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class UserDbContext : DbContext 
        {
        public UserDbContext() : base("Name=LocalDBAssurance")
        {

        }


        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Assure> Assures { get; set; }
        public DbSet<Sinistre> Sinistres { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Souscripteur> Souscripteurs { get; set; }
        public DbSet<Garantie> Garanties { get; set; }
        public DbSet<ContratGarantie> ContratsGarantie { get; set; }
        public DbSet<ImageSinistre> Images { get; set; }
        public DbSet<Rapport> Rapports { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ContratConfiguration());
            modelBuilder.Configurations.Add(new SinistreConfiguration());
            modelBuilder.Configurations.Add(new ContratGarantieConfiguration());

        }

        
    }

    

}

