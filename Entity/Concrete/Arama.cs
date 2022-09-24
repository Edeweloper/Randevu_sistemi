using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Arama
    {
        [Key]
        public int Arama_id { get; set; }
        public string Ad { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string? Konu { get; set; }
        public DateTime Aranma_Zamanı { get; set; }
        public int ArayanTipiId { get; set; }
        public int AramaTipiId { get; set; }
        public int KaydedenId { get; set; }
        public int ArananId { get; set; }
        public virtual ArayanTipi ArayanTipi { get; set; } = null!;
        public virtual AramaTipi AramaTipi { get; set; } = null!;
        public virtual AppUser Kaydeden { get; set; } = null!;
        public virtual AppUser Aranan { get; set; } = null!;

        public bool Is_deleted { get; set; }

    }
}
