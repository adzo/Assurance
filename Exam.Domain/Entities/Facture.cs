using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Facture
    {
        [Key]
        public int FactureId { get; set; }
        public string DateFacture { get; set; }
        public string Description { get; set; }
        public int Montant { get; set; }

        //Foreign Key
        public int SinistreId { get; set; }
        //Variable de navigation
        public virtual Sinistre Sinistre { get; set; }
    }
}
