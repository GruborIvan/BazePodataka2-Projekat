using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository.Interfaces
{
    public interface IKonsultantRepository
    {
        IEnumerable<Osoba> GetKonsultanti();
        Konsultant GetKonsultantById(int id);

        void AddKonsultant(Konsultant konsultant);
        void UpdateKonsultant(Konsultant konsultant);
        void DeleteKonsultant(Konsultant konsultant);

        IEnumerable<Ugovor> GetUgovori();
    }
}
