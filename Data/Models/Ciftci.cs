using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CiftciSatis.Data.Models
{
    public class Ciftci
    {
        [Key]
        public int CiftciId { get; set; }
        public string CiftciEmail { get; set; }
        public string CiftciSifre { get; set; }
        public string CiftciAd { get; set; }
        public string CiftciSoyad { get; set; }
        public string CiftciAdres { get; set; }
        public double CiftciBakiye { get; set; }

        public IList<Urunler> Urunlers { get; set; }
        public IList<Siparisler> Siparislers { get; set; }
    }
}
