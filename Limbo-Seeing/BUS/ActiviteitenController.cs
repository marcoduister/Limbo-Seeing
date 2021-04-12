using Limbo_Seeing.DAL;
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

        public ICollection<Activiteit> GetActiviteitens()
        {
            return DBContext.Activiteiten.ToList();
        }
        public ICollection<Activiteit> GetAllActiviteitenByUserID()
        {
            return DBContext.Activiteiten.Where(W => W.Gebruiker_Id == new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482")).ToList();
            //Alert het hier bovendstaande GebruikerId moet uit Settings gehaald worden
        }
        public Activiteit GetActiviteitbyGuid(Guid Id)
        {
            return DBContext.Activiteiten.First(F => F.Id == Id);
        }
        public bool Create()
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public bool update()
        {
            return true;
        }
    }
}
