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
    public class KonsultantRepository : IKonsultantRepository
    {
        private CompanyDbModelContainer db;

        public KonsultantRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddKonsultant(Konsultant konsultant)
        {
            konsultant.OsobaType = "KONSULTANT";
            db.Osobas.Add(konsultant);
            db.SaveChanges();
        }

        public void DeleteKonsultant(Konsultant konsultant)
        {
            db.Osobas.Remove(konsultant);
            db.SaveChanges();
        }

        public Konsultant GetKonsultantById(int id)
        {
            return db.Osobas.Find(id) as Konsultant;
        }

        public IEnumerable<Osoba> GetKonsultanti()
        {
            return db.Osobas.Where(x => x.OsobaType == "KONSULTANT");
        }

        public void UpdateKonsultant(Konsultant konsultant)
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

        public IEnumerable<Ugovor> GetUgovori()
        {
            return db.Ugovori;
        }
    }
}
