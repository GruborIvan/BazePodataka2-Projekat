using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository
{
    public interface ILokacijaRepository
    {
        IEnumerable<Lokacija> GetLokacije();
        Lokacija GetLokacijaById(int id);
        void AddLokacija(Lokacija lokacija);
        void UpdateLokacija(Lokacija lokacija);
        void DeleteLokacija(Lokacija lokacija);
    }
}
