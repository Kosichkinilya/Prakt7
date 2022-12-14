using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7_практос
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle rectangle = new Rectangle(default, default);

        public MainWindow()
        {
            InitializeComponent();
        }


      
        private void About_programm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косичкин Илья ИСП-34\nПрактическая №7\nИспользовать класс Pair (пара четных чисел). Определить производный класс Rectangle (прямоугольник) с характеристиками стороны прямоугольника. Определить методы вычисления периметра и площади прямоугольника.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Input_FirstSide.Clear();
            Input_SecondSide.Clear();
            PerimeterRectangle.Clear();
            SquareRectangle.Clear();
        }

        private void Perimeter_Click(object sender, RoutedEventArgs e) // Периметр
        {
            try
            {
                int firstside = Convert.ToInt32(Input_FirstSide.Text);
                int secondside = Convert.ToInt32(Input_SecondSide.Text);
                  
                rectangle = new Rectangle(firstside, secondside); 

                PerimeterRectangle.Text = rectangle.Perimeter(rectangle).ToString();  // Вывод
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно.");
                Input_FirstSide.Clear();
                Input_SecondSide.Clear();
            }
        }

        private void Square_Click(object sender, RoutedEventArgs e) // Площадь
        {

            try
            {
                int firstside = Convert.ToInt32(Input_FirstSide.Text);
                int secondside = Convert.ToInt32(Input_SecondSide.Text);

                rectangle = new Rectangle(firstside, secondside);

               SquareRectangle.Text = rectangle.Square(rectangle).ToString(); // Вывод
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно.");
                Input_FirstSide.Clear();
                Input_SecondSide.Clear();
            }
        }

    }
}
