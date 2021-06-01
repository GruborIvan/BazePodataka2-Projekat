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
    public class UgovoreniProizvodRepository : IUgovoreniProizvodRepository
    {
        private CompanyDbModelContainer db;

        public UgovoreniProizvodRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddUgovoreniProizvod(UgovoreniProizvod proizvod)
        {
            proizvod.PRID = db.UgovoreniProizvodi.OrderByDescending(x => x.PRID).First().PRID + 1;
            db.UgovoreniProizvodi.Add(proizvod);
            db.SaveChanges();
        }

        public void DeleteUgovoreniProizvod(UgovoreniProizvod proizvod)
        {
            db.UgovoreniProizvodi.Remove(proizvod);
            db.SaveChanges();
        }

        public IEnumerable<Osoba> GetDeveloperi()
        {
            return db.Osobas.Where(x => x.OsobaType == "DEVELOPER");
        }

        public IEnumerable<Osoba> GetKlijenti()
        {
            return db.Osobas.Where(x => x.OsobaType == "KLIJENT");
        }

        public IEnumerable<Osoba> GetKonsultanti()
        {
            return db.Osobas.Where(x => x.OsobaType == "KONSULTANT");
        }

        public UgovoreniProizvod GetUgovoreniProizvodById(int id)
        {
            return db.UgovoreniProizvodi.Find(id);
        }

        public IEnumerable<UgovoreniProizvod> GetUgovoreniProizvodi()
        {
            return db.UgovoreniProizvodi;
        }

        public void UpdateUgovoreniProizvod(UgovoreniProizvod proizvod)
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
