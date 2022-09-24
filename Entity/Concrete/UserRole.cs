using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class UserRole
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public int SekreterId { get; set; }
        [ForeignKey("SekreterId")]
        public AppUser Sekreter { get; set; }
        [ForeignKey("AdminId")]
        public AppUser Admin { get; set; }
    }
}
