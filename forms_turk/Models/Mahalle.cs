using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
   public class Mahalle
    {
        
        public int Id { get; set; }
        public Ilce Ilce { get; set; }
       
       
        public int IlceId { get; set; }
       
        [Required]
        public string MahalleAdi { get; set; }


    }
}
