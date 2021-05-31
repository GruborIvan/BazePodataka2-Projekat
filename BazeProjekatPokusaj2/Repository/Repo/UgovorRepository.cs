using BazeProjekatPokusaj2.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Repo
{
    public class UgovorRepository : IUgovorRepository
    {
        private CompanyDbModelContainer db;

        public UgovorRepository()
        {
            db = new CompanyDbModelContainer();
        }

        public void AddUgovor(Ugovor ugovor)
        {
            db.Ugovori.Add(ugovor);
            db.SaveChanges();
        }

        public void DeleteUgovor(Ugovor ugovor)
        {
            List<Osoba> osobe = db.Osobas.Where(x => x.OsobaType == "DEVELOPER" || x.OsobaType == "DIREKTOR" || x.OsobaType == "KONSULTANT").ToList();
            foreach (Osoba o in osobe)
            {
                Zaposleni z = o as Zaposleni;

                if (z.UgovorUID == ugovor.UID)
                {
                    if (z.OsobaType.Equals("DEVELOPER"))
                    {
                        db.Osobas.Remove(o);
                        db.SaveChanges();
                    }
                    else if (z.OsobaType.Equals("DIREKTOR"))
                    {
                        IDirektorRepository rep = new DirektorRepository();
                        Direktor dix = (Direktor)db.Osobas.Find(z.OID);
                        rep.DeleteDirektor(dix);
                    }
                    else if (z.OsobaType.Equals("KONSULTANT"))
                    {
                        // DELETE SVE IZ PRODUCTS TAMO...
                        // PUCACE OVDE ZATO!!
                        db.Osobas.Remove(o);
                        db.SaveChanges();
                    }

                }
            }

        }

        public Ugovor GetUgovorById(int id)
        {
            return db.Ugovori.Find(id);
        }

        public IEnumerable<Ugovor> GetUgovori()
        {
            return db.Ugovori;
        }

        public void UpdateUgovor(Ugovor ugovor)
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
