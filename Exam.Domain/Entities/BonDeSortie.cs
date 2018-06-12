using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Domain.Entities
{
    public class BonDeSortie
    {
        [Key]
        [ForeignKey("Sinistre")]
        public int BonDeSortieId { get; set; }
        public string DateCreation { get; set; }
        public string BonDeSortieNonSigne { get; set; }
        public string BonDeSortieSigne { get; set; }

        
        //navigation Properties
        public virtual Sinistre Sinistre { get; set; }

    }
}
