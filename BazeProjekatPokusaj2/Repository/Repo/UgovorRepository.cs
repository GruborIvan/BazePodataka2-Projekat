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
            db.Ugovori.Remove(ugovor);
            db.SaveChanges();
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
