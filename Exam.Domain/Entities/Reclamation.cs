using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class Reclamation
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int AssureId { get; set; }
        public Boolean status { get; set; }

        public virtual Assure Assure { get; set; }

    }
}
