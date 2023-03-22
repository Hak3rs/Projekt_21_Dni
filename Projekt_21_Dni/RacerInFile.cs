﻿using System;
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
