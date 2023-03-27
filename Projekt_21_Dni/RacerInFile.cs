using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_21_Dni
{
    public class RacerInFile : RacerBase
    {
        public RacerInFile(int id, string name, string surname, int age) : base(id, name, surname, age)
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

        public override void AddPoints(int pkt)
        {
            using (var writer = File.AppendText("F1_" + Id + "_" + Surname + ".txt"))
            {
                writer.WriteLine(pkt);
            }
        }
        public override Statistics GetStatistics()
        {
            var stat = new Statistics();
            int nr = 1;
            using (var reader = File.OpenText("F1_" + Id + "_" + Surname + ".txt"))
            {
                var line = reader.ReadLine();
                if (File.Exists("F1_" + Id + "_" + Surname + ".txt"))
                {
                    while (line != null)
                    {
                        var pkt  = int.Parse(line);
                        stat.AddPoints(pkt);
                        line = reader.ReadLine();
                        nr++;
                    }

                }

            }
            return stat;
        }
    }
}
