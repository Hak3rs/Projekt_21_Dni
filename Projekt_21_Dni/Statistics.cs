using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_21_Dni
{
    public class Statistics
    {
        public Statistics() 
        {
            this.Min = int.MaxValue;
            this.Max = int.MinValue;
            this.Suma = 0;
            this.Zlicz = 0;
        }
       
        #region Dane
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int Srednia 
        { 
            get 
            {
                return this.Suma / this.Zlicz;
            }
        }
        public int Suma { get; private set; }
        public int Zlicz { get; private set; }

        #endregion Dane

        #region Metody

        public void AddPoints(int pkt)
        {
            this.Zlicz++;
            this.Suma += pkt;
            this.Min = Math.Min(pkt, this.Min);
            this.Max = Math.Max(pkt, this.Max);
        }

        #endregion Metody
    }
}
