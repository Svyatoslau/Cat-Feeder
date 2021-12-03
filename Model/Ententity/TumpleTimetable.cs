using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class TumpleTimetable
    {
        private int weight;
        private DateTime time;

        public TumpleTimetable(int weight, DateTime time)
        {
            this.weight = weight;
            this.time = time;
        }
        public void SetTime(DateTime time)
        {
            this.time = time;
        }
        public void SetWeight(int weight)
        {
            this.weight = weight;
        }
        public DateTime GetTime()
        {
            return this.time;
        }
        public int GetWeight()
        {
            return this.weight;
        }
        public void ShowDateTime()
        {
            Console.WriteLine($"Текущая дата {this.time}"); ;
        }
    }
}