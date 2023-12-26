using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
    public class Ilce
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Sehir Sehir { get; set; }
      
        public int SehirId { get; set; }
      
        [Required]
        public string IlceAdi {  get; set; }
        

    } 
}
