using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class ImageSinistre
    {
        [Key]
        public int Id { get; set; }
        public string ImageLink { get; set; }
        public string ImageName { get; set; }

        public string Extension { get; set; }
        public int SinistreId { get; set; }
        public string Status { get; set; }
        public string DateImage { get; set; }


        public virtual Sinistre Sinistre { get; set; }

    }
}
