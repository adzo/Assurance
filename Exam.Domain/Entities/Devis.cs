using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Devis
    {
        [Key]
        public int Id { get; set; }
        public int SinistreId { get; set; }
        public string DateDevis { get; set; }
        public string Conformite { get; set; }
        public string DevisUrl { get; set; }

        public virtual Sinistre Sinistre { get; set; }

    }
}
