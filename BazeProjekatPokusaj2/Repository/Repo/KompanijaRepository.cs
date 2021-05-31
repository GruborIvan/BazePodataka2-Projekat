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

        public KompanijaRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddKompanija(Kompanija kompanija)
        {
            db.Kompanije.Add(kompanija);
            db.SaveChanges();
        }

        public void DeleteKompanija(Kompanija kompanija)
        {
            //Direktor d = db.Osobas.Where(x => x.OID == kompanija.Direktor.OID) as Direktor;
            //d.Kompanija = null;
            Direktor d = kompanija.Direktor;
            kompanija.Direktor = null;
            db.Osobas.Remove(d);
            db.SaveChanges();

            db.Kompanije.Remove(kompanija);
            db.SaveChanges();
        }

        public IEnumerable<Osoba> GetDirektori()
        {
            return db.Osobas.Where(x => x.OsobaType == "DIREKTOR");
        }

        public Kompanija GetKompanijaById(int id)
        {
            return db.Kompanije.Find(id);
        }

        public IEnumerable<Kompanija> GetKompanije()
        {
            return db.Kompanije;
        }

        public IEnumerable<Lokacija> GetLokacije()
        {
            return db.Lokacije;
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
