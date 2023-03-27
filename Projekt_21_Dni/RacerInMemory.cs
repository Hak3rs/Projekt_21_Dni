using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_21_Dni
{
    public class RacerInMemory : RacerBase
    {
        public RacerInMemory(int id, string name, string surname, int age) : base(id, name, surname, age)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        private List<int> Points = new List<int>();
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public override void AddPoints(int pkt)
        {
            this.Points.Add(pkt);
        }


        public override Statistics GetStatistics()
        {
            var stat = new Statistics();
            foreach (var pkt in Points)
            {
                stat.AddPoints(pkt);
            }
            return stat;

        }
    }
}
