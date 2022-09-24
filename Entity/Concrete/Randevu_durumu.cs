using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Randevu_durumu
    {
        [Key]
        public int RandevuID { get; set; }
        public string Randevu_Durumu { get; set; } = null!;
        public List<Randevular> Appoints { get; set; }
    }
}
