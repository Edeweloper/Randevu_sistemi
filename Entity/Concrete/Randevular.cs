using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Randevular
    {
        [Key]
        public int Randevu_id { get; set; }
        public string Randevuya_Gelen { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public string Konu { get; set; } = null!;
        public int Randevu_KaydedenId { get; set; }
        public int Ziyaret_EdilenKisiId { get; set; }
        public int Randevu_DurumuId { get; set; }
        public virtual AppUser Randevu_Kaydeden { get; set; }
        public virtual AppUser Ziyaret_EdilenKisi { get; set; }
        public virtual Randevu_durumu Randevu_Durumu { get; set; }
        public bool Is_deleted { get; set; }

    }
}
