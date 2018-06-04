using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Sinistre
    {
        public int SinistreId { get; set; }
        public string DateSinistre { get; set; }
        public string Nature { get; set; }
        public string Phase { get; set; }
        public string Etat { get; set; }
        public string Conducteur { get; set; }
        public Boolean Indemnise { get; set; }
        public Boolean IDA { get; set; }
        public string GarantieSinistre { get; set; }
        public string NumeroPermis { get; set; }
        public int PartDeResponsabilite { get; set; }
        public int MontantIndemnisation { get; set; }
        public string CompagnieAdverse { get; set; }
        public string DateDePermis { get; set; }
        public string DateIndemnisation { get; set; }
        public string VehiculeAdverse { get; set; }

        public Sinistre()
        {
            GarageExperts = new List<UserAccount>();
            BonsDeSorties = new List<BonDeSortie>();
            Factures = new List<Facture>();
            Confirmations = new List<Confirmation>();
        }


        //Foreign Key
        public int ContratId { get; set; }
        

        //Navigation Properties
        public virtual Contrat Contrat { get; set; }
        public virtual ICollection<UserAccount> GarageExperts { get; set; }
        public virtual ICollection<BonDeSortie> BonsDeSorties { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }
        public virtual ICollection<Confirmation> Confirmations { get; set; }
        
    }
}
