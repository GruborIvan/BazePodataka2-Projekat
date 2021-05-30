using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository
{
    public interface IDirektorRepository
    {
        IEnumerable<Direktor> GetDirektori();
        Direktor GetDirektorById(int id);
        void AddDirektor(Direktor direktor);
        void UpdateDirektor(Direktor direktor);
        void DeleteDirektor(Direktor direktor);
    }
}
