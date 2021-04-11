using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CiftciSatis.Data.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }
        public string MusteriEmail { get; set; }
        public string MusteriSifre { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriAdres { get; set; }
        public double MusteriBakiye { get; set; }

    }
}
