using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Garantie
    {
        public int Id { get; set; }
        public string GarantieName { get; set; }

        public virtual ICollection<ContratGarantie> Contrats { get; set; }


    }
}
