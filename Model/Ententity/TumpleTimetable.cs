using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class TumpleTimetable
    {
        private int weight;
        private DateTime time;

        public int Weight { get => weight; set => weight = value; }
        public DateTime Time { get => time; set => time = value; }

        public TumpleTimetable(int weight, DateTime time)
        {
            this.Weight = weight;
            this.Time = time;
        }

    }
}