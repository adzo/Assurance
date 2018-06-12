using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Assure
    {
       
        [Key]
        [ForeignKey("UserAccount")]
        public int AssureId { get; set; }
        public string TypeAssure { get; set; }
        public string TypeIdentifiant { get; set; }
        public int NumeroIdentifiant { get; set; }
        public string DateDelivreIdentifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateDeNaissance { get; set; }
        public string LieuDeNaissance { get; set; }
        public string Sexe { get; set; }
        public string SituationFamiliale { get; set; }
        public string Profession { get; set; }
        public string NumeroPermis { get; set; }
        public string DateDelivrePermis { get; set; }
        
        //Complex Types
        public  Addresse Addresse { get; set; }
        public  Contact Contact { get; set; }

        //Navigation Properties
        public virtual UserAccount UserAccount { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
        public virtual ICollection<Reclamation> Reclamations { get; set; }
        


    }
}
