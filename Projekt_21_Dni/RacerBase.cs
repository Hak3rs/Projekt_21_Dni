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
        public void AddPoints(string pkt)
        {
            if (int.TryParse(pkt, out int point))
            {
                this.AddPoints(point);
            }
            else
            {
                throw new Exception("Value is not INT");
            }
        }


        public void AddPlace(int place)
        {
            switch (place)
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

        public abstract Statistics GetStatistics();
    }
}
