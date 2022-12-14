using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_практос
{
    class Pair
    {
        // поля
        private int _onevalue;
        private int _twovalue;

        // конструктор класса с int параметрами 
        public Pair(int oneValue, int twoValue)
        {
            OneValue = oneValue;
            TwoValue = twoValue;
        }

        // свойства класса 
        public int OneValue // свойства 
        {
            get => _onevalue; //получаем значения поля _onevalue
            set // устаналиваем значение для поля _onevalue
            {
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Свойство должно четным");
                }

                _onevalue = value; // устанавливаем значение для поля _onevalue;
            }
        }

        public int TwoValue // свойства 
        {
            get => _twovalue; //получаем значения поля _twovalue
            set // устаналиваем значение для поля _twovalue
            {
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Свойство должно четным");
                }

                _twovalue = value; // устанавливаем значение для поля _twovalue;
            }
        }
    }
}
