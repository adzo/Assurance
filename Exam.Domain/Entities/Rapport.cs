using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Rapport
    {
        [Key]
        public int Id { get; set; }
        public string DateRapport { get; set; }
        public string RapportName { get; set; }
        public string RapportUrl { get; set; }
        public string RapportExtension { get; set; }
        public int Version { get; set; }

        public int SinistreId { get; set; }
        public virtual Sinistre Sinistre { get; set; }

    }
}
