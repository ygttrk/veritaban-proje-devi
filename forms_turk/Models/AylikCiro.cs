using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
    public class AylikCiro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ay_bilgisi { get; set; }

        [Required]
        public decimal ciro {  get; set; }
    }
}
