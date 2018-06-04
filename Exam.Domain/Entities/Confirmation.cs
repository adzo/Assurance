using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Confirmation
    {
        [Key]
        public int Id { get; set; }
        public string DateVersion { get; set; }
        public int Version { get; set; }
        public string Rapport { get; set; }

        //Foreign Key
        public int SinistreId { get; set; }
        //navigation Properties
        public virtual Sinistre Sinistre { get; set; }

    }
}
