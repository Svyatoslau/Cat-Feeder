using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Ententity
{


    public abstract class Feeder
    {
        private string name; // Имя
        public string Name
        {
            get { return name; }
            set => name = value;
        }
        private int value; // Наполненность кормушки
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }


        private string type;
        public string Type { get => type; set => type = value; }


        private List<Note> notes;// Записи

        public List<Note> Notes { get => notes; set => notes = value; }
        

        private Timetable timetable; // Прикрепленное расписсание
        public Timetable Timetable { get => timetable; set => timetable = value; }

    }
    

    

   
    

    
}
