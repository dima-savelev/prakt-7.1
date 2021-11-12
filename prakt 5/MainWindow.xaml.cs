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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prakt_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Rational pair1 = new Rational(0, 0);
        Rational pair2 = new Rational(0, 0);
        Rational pair3 = new Rational(0, 0);
        private void Compare(object sender, RoutedEventArgs e)
        {
            firsrtPair1.Text = pair1.First.ToString();
            firsrtPair2.Text = pair1.Second.ToString(); 
            secondPair1.Text = pair2.First.ToString();
            secondPair2.Text = pair2.Second.ToString();
            thirdPair1.Text  = pair3.First.ToString();
            thirdPair2.Text  = pair3.Second.ToString();
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == false)
            {
                if (pair1)
                {
                    MessageBox.Show("Пара равна", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пара не равна", "Результат сравнения", MessageBoxButton.OK);
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                if (pair2)
                {
                    MessageBox.Show("Пара равна", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пара не равна", "Результат сравнения", MessageBoxButton.OK);
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                if (pair3)
                {
                    MessageBox.Show("Пара равна", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пара не равна", "Результат сравнения", MessageBoxButton.OK);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                if (pair1 == pair2)
                {
                    MessageBox.Show("Пары равны", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения", MessageBoxButton.OK);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                if (pair1 == pair3)
                {
                    MessageBox.Show("Пары равны", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения", MessageBoxButton.OK);
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                if (pair2 == pair3)
                {
                    MessageBox.Show("Пары равны", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения", MessageBoxButton.OK);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                if (pair1 == pair2 && pair2==pair3)
                {
                    MessageBox.Show("Пары равны", "Результат сравнения", MessageBoxButton.OK);
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения", MessageBoxButton.OK);
            }
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            firsrtPair1.Text = pair1.First.ToString();
            firsrtPair2.Text = pair1.Second.ToString();
            secondPair1.Text = pair2.First.ToString();
            secondPair2.Text = pair2.Second.ToString();
            thirdPair1.Text = pair3.First.ToString();
            thirdPair2.Text = pair3.Second.ToString();
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == false)
            {
                resultMultiply.Text = Convert.ToString(pair1.Multiply());
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                resultMultiply.Text = Convert.ToString(pair2.Multiply());
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                resultMultiply.Text = Convert.ToString(pair3.Multiply());
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                Pair result = pair1.Multiply(pair2);
                resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                Pair result = pair1.Multiply(pair3);
               resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                Pair result = pair2.Multiply(pair3);
               resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                Pair result = pair1.Multiply(pair2, pair3);
               resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            firsrtPair1.Text = pair1.First.ToString();
            firsrtPair2.Text = pair1.Second.ToString();
            secondPair1.Text = pair2.First.ToString();
            secondPair2.Text = pair2.Second.ToString();
            thirdPair1.Text = pair3.First.ToString();
            thirdPair2.Text = pair3.Second.ToString();
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == false)
            {
                resultMinus.Text = Convert.ToString(pair1.Minus());
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                resultMinus.Text = Convert.ToString(pair2.Minus());
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                resultMinus.Text = Convert.ToString(pair3.Minus());
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                Pair result = pair1.Minus(pair2);
                resultMinus.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                Pair result = pair1.Minus(pair3);
                resultMinus.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                Pair result = pair2.Minus(pair3);
                resultMinus.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                Pair result = pair1-pair2-pair3;
                resultMinus.Text = Convert.ToString(result.First + " , " + result.Second);
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            int addValue;
            switch(((TextBox)sender).Name)
            {
                case "firsrtPair1":
                    int.TryParse(firsrtPair1.Text, out addValue);
                    pair1.First = addValue;
                    break;
                case "firsrtPair2":
                    int.TryParse(firsrtPair2.Text, out addValue);
                    pair1.Second = addValue;
                    break;
                case "secondPair1":
                    int.TryParse(secondPair1.Text, out addValue);
                    pair2.First = addValue;
                    break;
                case "secondPair2":
                    int.TryParse(secondPair2.Text, out addValue);
                    pair2.Second = addValue;
                    break;
                case "thirdPair1":
                    int.TryParse(thirdPair1.Text, out addValue);
                    pair3.First = addValue;
                    break;
                case "thirdPair2":
                    int.TryParse(thirdPair2.Text, out addValue);
                    pair3.Second = addValue;
                    break;
            }
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Савельев Дмитрий Александрович В13\nПрактическая работа №7\nИспользовать базовый класс Pair (пара целых чисел). Создать производный класс Rational; определить новые операции сложения (а, b) + (с, d) = (ad + be, bd) и деления (а, b)/ (с, d) = (ad, be); переопределить операцию вычитания (а, b) - (с, d) = (ad - be, bd).", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PreviewTextBoxInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int addvalue))
            {
                e.Handled = true;
            }
        }
    }
}
