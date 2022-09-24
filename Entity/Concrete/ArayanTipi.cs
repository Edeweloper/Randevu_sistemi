using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class ArayanTipi
    {
        [Key]
        public int Arayan_tipi_id { get; set; }
        public string Arayan_tipi { get; set; }
        public List<Arama> Aramalar { get; set; }

    }
}
