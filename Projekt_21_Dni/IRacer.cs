using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_21_Dni
{
    public interface IRacer
    {
        Statistics GetStatistics();
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        int Id { get; }
        
    }
}
