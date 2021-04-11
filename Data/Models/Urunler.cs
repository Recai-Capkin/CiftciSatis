using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CiftciSatis.Data.Models
{
    public class Urunler
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunTur { get; set; }
        public int UrunMiktar { get; set; }
        public string UrunRenk { get; set; }
        public int UrunRandıman { get; set; }
        public DateTime UrunKTarih { get; set; }

        public int CiftciId { get; set; }
    }
}
