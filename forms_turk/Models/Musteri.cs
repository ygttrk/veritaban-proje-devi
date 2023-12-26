using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
   public class Musteri
    {
        [Key]
        public int Id {  get; set; }
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string SirketAdi { get; set; }
        [Required]
        public bool IsKurumsal { get; set; }
        [Required]
        public string Iletisim { get; set; }
       
        
        public Mahalle Mahalle { get; set; }
        
        public int MahalleId {  get; set; }
       
        [Required]
        public string AdresDetay { get; set; }


    }
}
