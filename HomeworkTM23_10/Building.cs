using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTM23_10
{
    class Building
    {
        //Поля
        private int number;
        private int height;
        private int floors;
        private int flats;
        private int entrances;

        //Свойства
        public int Entrances
        {
            get { return entrances; }
            set { entrances = value; }
        }
        //Конструкторы
        public Building()
        {
        }
        public Building(int entrances, int floors, int flats, int height, int number)
        {
            this.entrances = entrances;
            this.floors = floors;
            this.flats = flats;
            this.number = number;
            this.height = height;
        }
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        public int Flats
        {
            get { return flats; }
            set { flats = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Number()
        {
            return number;
        }
        public void HeightOfFloor(int height, int floors)
        {
            Console.WriteLine("Высота этажа составляет: " + height / floors + " метров");
        }
        public int AmountOfFlatsInEntrance() => flats / entrances;
        public int AmountOfFlatsOnFloor() => flats / entrances / floors;
        public double HeightFloor()
        {
            if (floors != 0)
            {
                return (double)height / floors;
            }
            else
            {
                return -1;
            }
        }
        static int num_house1 = 1;
        public int Getnum_house()
        {
            return num_house1 + 1;
        }
    }
}
