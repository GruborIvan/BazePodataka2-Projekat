using BazeProjekatPokusaj2.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Repo
{
    public class KompanijaRepository : IKompanijaRepository
    {
        private CompanyDbModelContainer db;

        public void AddKompanija(Kompanija kompanija)
        {
            db.Kompanije.Add(kompanija);
            db.SaveChanges();
        }

        public void DeleteKompanija(Kompanija kompanija)
        {
            db.Kompanije.Remove(kompanija);
            db.SaveChanges();
        }

        public Kompanija GetKompanijaById(int id)
        {
            return db.Kompanije.Find(id);
        }

        public IEnumerable<Kompanija> GetKompanije()
        {
            return db.Kompanije;
        }

        public void UpdateKompanija(Kompanija kompanija)
        {
            try
            {
                db.SaveChanges();
            }
            catch (DBConcurrencyException ce)
            {
                Trace.TraceInformation(ce.Message);
            }
        }
    }
}
