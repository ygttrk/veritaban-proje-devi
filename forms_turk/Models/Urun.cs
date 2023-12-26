using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UrunMarka { get; set; }
        
        public string UrunModel { get; set; }
        [Required]
        public string UrunKodu { get; set; }
        [Required]
        public decimal Fiyat { get; set; }
        [Required]
        public int StokBilgisi { get; set; }
       
        public UrunTuru UrunTuru { get; set; }
        [Required]
       
        public int UrunTuruId { get; set; }
       
    }
}
