using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Interfaces
{
    public interface IUgovoreniProizvodRepository
    {
        IEnumerable<UgovoreniProizvod> GetUgovoreniProizvodi();
        UgovoreniProizvod GetUgovoreniProizvodById(int id);
        void AddUgovoreniProizvod(UgovoreniProizvod proizvod);
        void UpdateUgovoreniProizvod(UgovoreniProizvod proizvod);
        void DeleteUgovoreniProizvod(UgovoreniProizvod proizvod);


        // GET DEPENDENCIES
        IEnumerable<Osoba> GetKlijenti();
        IEnumerable<Osoba> GetDeveloperi();
        IEnumerable<Osoba> GetKonsultanti();
    }
}
