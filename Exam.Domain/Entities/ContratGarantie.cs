using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class ContratGarantie
    {
        [Key]
        [ForeignKey("Contrat")]
        [Column(Order = 1)]
        public int ContratId { get; set; }
        [Key]
        [ForeignKey("Garantie")]
        [Column(Order = 2)]
        public int GarantieId { get; set; }
        public int Capital { get; set; }
        public int Franchise { get; set; }

        //Navigation properties
        public virtual Contrat Contrat { get; set; }
        public virtual Garantie Garantie { get; set; }
    }
}
