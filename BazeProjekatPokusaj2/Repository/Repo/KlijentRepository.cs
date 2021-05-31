using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Repo
{
    public class KlijentRepository : IKlijentRepository
    {
        private CompanyDbModelContainer db;

        public KlijentRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddKlijent(Klijent klijent)
        {
            klijent.OsobaType = "KLIJENT";
            db.Osobas.Add(klijent);
            db.SaveChanges();
        }

        public void DeleteKlijent(Klijent klijent)
        {
            db.Osobas.Remove(klijent);
            db.SaveChanges();
        }

        public Klijent GetKlijentById(int id)
        {
            return db.Osobas.Find(id) as Klijent;
        }

        public IEnumerable<Osoba> GetKlijenti()
        {
            return db.Osobas.Where(x => x.OsobaType == "KLIJENT");
        }

        public void UpdateKlijent(Klijent klijent)
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
