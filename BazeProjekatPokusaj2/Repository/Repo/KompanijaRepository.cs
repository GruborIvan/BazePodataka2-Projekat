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
            Direktor d = kompanija.Direktor;
            kompanija.Direktor = null;
            db.Osobas.Remove((Direktor)db.Osobas.Find(d.OID));
            db.Lokacije.Remove(db.Lokacije.Find(kompanija.Lokacija.LokID));
            kompanija.Lokacija = null;

            db.Kompanije.Remove(db.Kompanije.Find(kompanija.KID));
            db.SaveChanges();
        }

        public IEnumerable<Osoba> GetDirektori()
        {
            List<Osoba> osobe = db.Osobas.Where(x => x.OsobaType == "DIREKTOR").ToList();
            foreach(Kompanija k in db.Kompanije)
            {
                Osoba o = osobe.Find(x => x.OID == k.Direktor.OID);
                if (o != null)
                {
                    osobe.Remove(o);
                }
            }
            return osobe;
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
            List<Lokacija> Lokacije = db.Lokacije.ToList();
            foreach(Kompanija k in db.Kompanije)
            {
                if (Lokacije.Find(x => x.LokID == k.Lokacija.LokID) != null)
                {
                    Lokacije.Remove(Lokacije.Find(x => x.LokID == k.Lokacija.LokID));
                }
            }
            return Lokacije;
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
