using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            db.Osobas.Add(direktor);
            db.SaveChanges();

            //var oid = new SqlParameter("@OID", db.Osobas.OrderByDescending(x => x.OID).First().OID + 1);
            //var ime = new SqlParameter("@Ime", direktor.Ime);
            //var prezime = new SqlParameter("@Prezime", direktor.Prezime);
            //var jmbg = new SqlParameter("@JMBG", direktor.JMBG);
            //var radnistaz = new SqlParameter("@RadniStaz", direktor.RadniStaz);
            //var uid = new SqlParameter("@UgovorId", direktor.UgovorUID);
            //db.Database.ExecuteSqlCommand("exec [dbo].[C_INS_Direktori] @OID,@Ime,@Prezime,@JMBG,@RadniStaz,@UgovorId",
            //    oid, ime, prezime, jmbg, radnistaz, uid);
        }

        public void DeleteDirektor(Direktor direktor)
        {
            foreach(Kompanija k in db.Kompanije.Where(x => x.Direktor.OID == direktor.OID))
            {
                db.Kompanije.Remove(k);
            }
            db.SaveChanges();
            Osoba o = db.Osobas.Find(direktor.OID);  //NEW
            db.Osobas.Remove(o);
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

        public IEnumerable<Ugovor> GetUgovori()
        {
            return db.Ugovori;
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
