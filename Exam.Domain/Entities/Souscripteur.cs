using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Souscripteur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string TypeSouscripteur { get; set; }
        public string TypeIdentifiant { get; set; }
        public string Numero { get; set; } 
        public string DateDelivre { get; set; }
        public string RaisonSocial { get; set; }
        public string FormeJuridique { get; set; }
        public string DateCreation { get; set; }
        public string Activite { get; set; }

        //Complex Types
        public Addresse Addresse { get; set; }
        public Contact Contact { get; set; }

        //Navigation Properties
        public virtual ICollection<Contrat> Contrats { get; set; }

    }
}
