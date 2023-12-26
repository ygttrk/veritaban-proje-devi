using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
    public class AlisVeris
    {
        
        public int Id { get; set; }
        [ForeignKey("Urunid")]
        public List<Urun> Uruns { get; set; }

        [Required]
        public int UrunId { get; set; }

       
        public Musteri Musteri { get; set; }
        [Required]
       

        public Personel Personel { get; set; }
        [Required]
        public int PersonelId { get; set; }
       

        [Required]
        public int UrunAdeti {  get; set; }

        [Required]
        public bool IsAlis { get; set; }

        [Required]
        public decimal ToplamTutar { get; set; }

        [Required]
        public DateTime IslemTarihi { get; set; }

    }
}
    