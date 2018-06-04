using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Exam.Domain.Entities
{
    public class BonDeSortie
    {
        [Key]
        public int Id { get; set; }
        public string DateCreation { get; set; }
        public string BonDeSortieNonSigne { get; set; }
        public string BonDeSortieSigne { get; set; }

        //Foreign Key
        public int SinistreId { get; set; }
        //navigation Properties
        public virtual Sinistre Sinistre { get; set; }

    }
}
