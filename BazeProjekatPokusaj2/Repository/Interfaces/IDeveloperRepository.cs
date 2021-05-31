using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Interfaces
{
    public interface IDeveloperRepository
    {
        IEnumerable<Osoba> GetDeveloperi();
        Developer GetDeveloperById(int id);
        void AddDeveloper(Developer developer);
        void UpdateDeveloper(Developer developer);
        void DeleteDeveloper(Developer developer);

        IEnumerable<Ugovor> GetUgovori();
    }
}
