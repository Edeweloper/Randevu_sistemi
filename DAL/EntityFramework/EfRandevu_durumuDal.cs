﻿using DAL.Abstract;
using DAL.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfRandevu_durumuDal : GenericRepository<Randevu_durumu>, IRandevu_durumuDal
    {
    }
}
