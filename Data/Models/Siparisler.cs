using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CiftciSatis.Data.Models
{
    public class Siparisler
    {
        [Key]
        public int SiparisId { get; set; }
        public int SiparisMiktar { get; set; }
        public double SiparisTutar { get; set; }
        public DateTime SiparisKTarih { get; set; }

        [ForeignKey("Ciftci")]
        public int CiftciId { get; set; }
        public virtual Ciftci Ciftci { get; set; }
        public int MusteriId { get; set; }
        public int UrunId { get; set; }

    }
}
