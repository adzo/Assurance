using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Vehicule
    {
        [Key]
        
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Genre { get; set; }
        public string Usage { get; set; }
        public string Constructeur { get; set; }
        public string Marque { get; set; }
        public string Couleur { get; set; }
        public string TypeConstructeur { get; set; }
        public string NumeroDeSerie { get; set; }
        public string DPMC { get; set; }
        public string Carrosserie { get; set; }
        public int NombreDePlace { get; set; }
        public int? NombreDebout { get; set; }
        public string Energie { get; set; }
        public int? PuissanceFiscale { get; set; }
        public int? Cylindree { get; set; }
        public int? PoidVide { get; set; }
        public int? CHargeUtile { get; set; }
        public int? PTAC { get; set; }
        public int? NumeroRemorque { get; set; }
        public string TypeRemorque { get; set; }
        public int? PoidVideRemorque { get; set; }
        public int? ChargeUtileRemorque { get; set; }
        public Boolean Delegation { get; set; }
        public string Organisme { get; set; }
        public int? Duree { get; set; }
        public int? ValeurANeuf { get; set; }
        public int? ValeurVenale { get; set; }
        public int? Classe { get; set; }
        public string Companie { get; set; }
        public string DateReleve { get; set; }


      
        //navigation properties
        public virtual Contrat Contrat { get; set; }


    }
}
