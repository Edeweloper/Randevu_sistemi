using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Is_Deleted { get; set; }
        public bool Is_Admin { get; set; }

    }
}
