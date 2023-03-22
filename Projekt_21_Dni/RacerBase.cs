using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_21_Dni
{
    public abstract class RacerBase : IRacer
    {
        public RacerBase(int id, string name, string surname, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public abstract void AddPoints(int pkt);
        public abstract void AddPoints(string pkt);
        public abstract Statistics GetStatistics();
    }
}
