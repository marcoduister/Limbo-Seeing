﻿using Limbo_Seeing.DAL;
using Limbo_Seeing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.BUS
{
    class ActiviteitenController
    {
        Limbo_SeeingContext DBContext = new Limbo_SeeingContext();

        public ICollection<Activiteiten> GetActiviteitens()
        {
            return DBContext.Activiteiten.ToList();
        }
    }
}
