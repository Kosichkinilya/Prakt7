using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_практос
{
    class Rectangle : Pair
    {
        // Поля
        private double _firstside;
        private double _secondside;

        // конструктор класса с int параметрами И аргументы
        // (base - Доступ к элементам базового 
        // класса, в том числе и конструктору)
        public Rectangle(int oneValue, int twoValue) : base(oneValue, twoValue)
        {
            Firstside = oneValue;
            Secondside = twoValue;
        }

        // свойства 
        public double Firstside 
        {
            get => _firstside; // получаем значение поля _firstside;
            set  // устанавливаем значения для поля _firstside;
            {
                if (value < 0)
                {
                    throw new ArgumentException("Свойство должно быть больше или равно 0");
                }
                _firstside = value; // устанавливаем значение для поля _firstside;
            }
        }

        public double Secondside // свойства 
        {
            get => _secondside; // получаем значение поля _secondside;
            set // устанавливаем значение поля _secondside;
            {
                if (value < 0)
                {
                    throw new ArgumentException("Свойство должно быть больше или равно 0");
                }
                _secondside = value; // устанавливаем значение для поля _secondside;
            }
        }

        public int Perimeter(Rectangle rectangle) // вычисление периметра a * 2 + b * 2
        {
            return rectangle.OneValue * 2 + rectangle.TwoValue * 2;
        }

        public int Square(Rectangle rectangle) // вычисление площади a * b
        {
            return rectangle.OneValue * rectangle.TwoValue;
        }
    }
}
