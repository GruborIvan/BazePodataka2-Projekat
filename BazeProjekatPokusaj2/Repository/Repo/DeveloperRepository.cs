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
    public class DeveloperRepository : IDeveloperRepository
    {
        private CompanyDbModelContainer db;

        public DeveloperRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddDeveloper(Developer developer)
        {
            developer.OsobaType = "DEVELOPER";
            db.Osobas.Add(developer);
            db.SaveChanges();
        }

        public void DeleteDeveloper(Developer developer)
        {
            foreach(UgovoreniProizvod up in db.UgovoreniProizvodi)
            {
                if (up.Developer.OID.Equals(developer.OID))
                    db.UgovoreniProizvodi.Remove(up);
            }
            db.SaveChanges();
            db.Osobas.Remove(developer);
            db.SaveChanges();
        }

        public Developer GetDeveloperById(int id)
        {
            return db.Osobas.Find(id) as Developer;
        }

        public IEnumerable<Osoba> GetDeveloperi()
        {
            return db.Osobas.Where(x => x.OsobaType == "DEVELOPER");
        }

        public IEnumerable<Ugovor> GetUgovori()
        {
            return db.Ugovori;
        }

        public void UpdateDeveloper(Developer developer)
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
