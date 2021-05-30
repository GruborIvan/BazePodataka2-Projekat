using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Interfaces
{
    public interface IUgovorRepository
    {
        IEnumerable<Ugovor> GetUgovori();
        Ugovor GetUgovorById(int id);
        void AddUgovor(Ugovor ugovor);
        void UpdateUgovor(Ugovor ugovor);
        void DeleteUgovor(Ugovor ugovor);
    }
}
