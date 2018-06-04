using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class SinistreUserAccount
    {
        [Key]
        [ForeignKey("Sinistre")]
        [Column(Order = 1)]
        public int SinistreId { get; set; }
        [Key]
        [ForeignKey("UserAccount")]
        [Column(Order = 2)]
        public int UserAcountId { get; set; }
    }
}
