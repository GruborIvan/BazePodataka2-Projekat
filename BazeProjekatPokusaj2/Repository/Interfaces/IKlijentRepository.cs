using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeProjekatPokusaj2.Repository
{
    public interface IKlijentRepository
    {
        IEnumerable<Klijent> GetKlijenti();
        Klijent GetKlijentById();
        void AddKlijent(Klijent klijent);
        void UpdateKlijent(Klijent klijent);
        void DeleteKlijent(Klijent klijent);
    }
}
