using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Repo
{

    public class LokacijaRepository : ILokacijaRepository
    {
        private CompanyDbModelContainer db;

        public LokacijaRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddLokacija(Lokacija lokacija)
        {
            db.Lokacije.Add(lokacija);
            db.SaveChanges();
        }

        public void DeleteLokacija(Lokacija lokacija)
        {
            db.Lokacije.Remove(lokacija);
            db.SaveChanges();
        }

        public Lokacija GetLokacijaById(int id)
        {
            return db.Lokacije.Find(id);
        }

        public IEnumerable<Lokacija> GetLokacije()
        {
            return db.Lokacije;
        }

        public void UpdateLokacija(Lokacija lokacija)
        {
            try
            {
                db.SaveChanges();
            }
            catch(DBConcurrencyException ce)
            {
                Trace.TraceInformation(ce.Message);
            }
        }
    }
}
