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
            this.Sum = 0;
            this.Count = 0;
        }
       
        #region Dane
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int Average
        { 
            get 
            {
                return this.Sum / this.Count;
            }
        }
        public int Sum { get; private set; }
        public int Count { get; private set; }

        #endregion Dane

        #region Metody

        public void AddPoints(int pkt)
        {
            this.Count++;
            this.Sum += pkt;
            this.Min = Math.Min(pkt, this.Min);
            this.Max = Math.Max(pkt, this.Max);
        }

        #endregion Metody
    }
}
