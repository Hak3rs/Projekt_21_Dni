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
        public const string filename = "F1_Statystyka.txt";
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
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(Id +" "+ pkt);
            }
        }
        public override void AddPoints(string pkt)
        {
            if (Int32.TryParse(pkt, out int point))
            {
                this.AddPoints(point);
            }
            else
            {
                throw new Exception("Value is not INT");
            }
        }
        public void Miejsce(int miejsce)
        {
            switch (miejsce)
            {
                case 1:
                    this.AddPoints(25);
                    break;
                case 2:
                    this.AddPoints(20);
                    break;
                case 3:
                    this.AddPoints(15);
                    break;
                case 4:
                    this.AddPoints(10);
                    break;
                case 5:
                    this.AddPoints(8);
                    break;
                case 6:
                    this.AddPoints(6);
                    break;
                case 7:
                    this.AddPoints(5);
                    break;
                case 8:
                    this.AddPoints(3);
                    break;
                case 9:
                    this.AddPoints(2);
                    break;
                case 10:
                    this.AddPoints(1);
                    break;
                case 11:
                    this.AddPoints(0);
                    break;
                default:
                    throw new Exception("Nieprawidlowe miejsce");
            }
        }
        public override Statistics GetStatistics()
        {
            List<Statistics> stat = new List<Statistics>();
            var stat1 = new Statistics();
            var stat2 = new Statistics();
            var stat3 = new Statistics();
            var stat4 = new Statistics();
            var stat5 = new Statistics();
            var stat6 = new Statistics();
            var stat7 = new Statistics();
            var stat8 = new Statistics();
            var stat9 = new Statistics();
            var stat10 = new Statistics();
            var stat11 = new Statistics();
            int nr = 1;
            using (var reader = File.OpenText(filename))
            {
                var line = reader.ReadLine();
                if (File.Exists(filename))
                {
                    while (line != null)
                    {
                        string[] odczyt = line.Split(" ");
                        var idRacer = int.Parse(odczyt[0]);
                        var pktRacer = int.Parse(odczyt[1]);
                        switch (idRacer)
                        {
                            case 1:
                                stat1.AddPoints(pktRacer);
                                break;
                            case 2:
                                stat2.AddPoints(pktRacer);
                                break;
                            case 3:
                                stat3.AddPoints(pktRacer);
                                break;
                            case 4:
                                stat4.AddPoints(pktRacer);
                                break;
                            case 5:
                                stat5.AddPoints(pktRacer);
                                break;
                            case 6:
                                stat6.AddPoints(pktRacer);
                                break;
                            case 7:;
                                stat7.AddPoints(pktRacer);
                                break;
                            case 8:;
                                stat8.AddPoints(pktRacer);
                                break;
                            case 9:
                                stat9.AddPoints(pktRacer);
                                break;
                            case 10:
                                stat10.AddPoints(pktRacer);
                                break;
                            case 11:
                                stat11.AddPoints(pktRacer);
                                break;
                            default:
                                break;
                        }

                        line = reader.ReadLine();
                        nr++;
                    }

                }
                return stat;

            }
        }
    }
}
