using BazeProjekatPokusaj2.Repository.Interfaces;
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

            //var oid = new SqlParameter("@OID", db.Osobas.OrderByDescending(x => x.OID).First().OID + 1);
            //var ime = new SqlParameter("@Ime", konsultant.Ime);
            //var prezime = new SqlParameter("@Prezime", konsultant.Prezime);
            //var jmbg = new SqlParameter("@JMBG", konsultant.JMBG);
            //var radnistaz = new SqlParameter("@RadniStaz", konsultant.RadniStaz);
            //var uid = new SqlParameter("@UgovorId", konsultant.UgovorUID);
            //db.Database.ExecuteSqlCommand("exec [dbo].[C_INS_Konsultanti] @OID,@Ime,@Prezime,@JMBG,@RadniStaz,@UgovorId",
            //    oid, ime, prezime, jmbg, radnistaz, uid);
        }

        public void DeleteKonsultant(Konsultant konsultant)
        {
            foreach(UgovoreniProizvod up in db.UgovoreniProizvodi)
            {
                if (up.Konsultant.OID.Equals(konsultant.OID))
                    db.UgovoreniProizvodi.Remove(up);
            }
            db.SaveChanges();
            db.Osobas.Remove(db.Osobas.Find(konsultant.OID));
            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {

            }
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
