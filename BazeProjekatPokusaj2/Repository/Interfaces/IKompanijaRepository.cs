using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Interfaces
{
    public interface IKompanijaRepository
    {
        IEnumerable<Kompanija> GetKompanije();
        Kompanija GetKompanijaById(int id);
        void AddKompanija(Kompanija kompanija);
        void UpdateKompanija(Kompanija kompanija);
        void DeleteKompanija(Kompanija kompanija);
    }
}
