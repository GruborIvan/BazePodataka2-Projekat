using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Repo
{
    public class DirektorRepository : IDirektorRepository
    {
        private CompanyDbModelContainer db;

        public DirektorRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddDirektor(Direktor direktor)
        {
            direktor.OsobaType = "DIREKTOR";
            direktor.UgovorUID = 3;
            db.Osobas.Add(direktor);
            db.SaveChanges();
        }

        public void DeleteDirektor(Direktor direktor)
        {
            db.Osobas.Remove(direktor);
            db.SaveChanges();
        }

        public Direktor GetDirektorById(int id)
        {
            Osoba o = db.Osobas.Find(id);
            return o as Direktor;
        }

        public IEnumerable<Osoba> GetDirektori()
        {
            return db.Osobas.Where(x => x.OsobaType == "DIREKTOR");
        }

        public void UpdateDirektor(Direktor direktor)
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
