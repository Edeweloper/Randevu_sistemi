using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AramaTipi
    {
        [Key]
        public int Arama_tipi_id { get; set; }
        public string Arama_tipi { get; set; } = null!;
        public List<Arama> Aramalar { get; set; }
       
    }
}
