using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Configurations
{
    public class ContratConfiguration : EntityTypeConfiguration<Contrat>
    {
        public ContratConfiguration()
        {
            // 1 to 1 Relation between Contrat et Vehicule
            //HasRequired(v => v.Vehicule).WithOptional(c => c.Contrat);
           




            //One to many Relation Between Contrat et Assuréé
            HasRequired<Assure>(a => a.Assure).
                WithMany(a => a.Contrats).
                HasForeignKey(s => s.AssureId);

            //One to many Relation Between Contrat et Souscripteur
            HasRequired<Souscripteur>(a => a.Souscripteur).
                WithMany(a => a.Contrats).
                HasForeignKey(s => s.SouscripteurId);

        }

        


    }
}
