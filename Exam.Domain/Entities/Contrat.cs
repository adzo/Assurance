using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Contrat
    {
        [Key]
        [ForeignKey("Vehicule")]
        public int ContratId { get; set; }
        public string Compagnie { get; set; }
        public string Agence { get; set; }
        public string Categorie { get; set; }
        public string DateSouscription { get; set; }
        public string DateEffet { get; set; }
        public string Periodicite { get; set; }
        public int Fractionnement { get; set; }
        public string DateEcheance { get; set; }
        public int PrimeAnnuelle { get; set; }
        public int PrimeComptant { get; set; }

        //Foreign Keys
        public int SouscripteurId { get; set; }
        public int AssureId { get; set; }
        


        //Navigation Properties
        public virtual Souscripteur Souscripteur { get; set; }
        public virtual Assure Assure { get; set; }
        public virtual Vehicule Vehicule { get; set; }
        //1 contrat peut avoir plusieur sinistres
        public virtual ICollection<Sinistre> Sinistres { get; set; }

        //Relation Many to many Porteuse de Données
        public virtual ICollection<ContratGarantie> Garanties { get; set; }

    }
}
