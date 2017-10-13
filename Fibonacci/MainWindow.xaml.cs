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

namespace Fibonacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            //Using list to hold details of fibonacci numbers
            List<int> numberList = new List<int>();
            bool stopSearch = false;
            int firstNumber = 0;
            int secondNumber = 0;
            int additionResult = 0;
            int maxNumber = Convert.ToInt16( tbxMaxFibonacciNumber.Text.Trim());
            //Add two default numbers in fibonacci sequence
            numberList.Add(0);
            numberList.Add(1);        
            do
            {
                firstNumber = numberList.ElementAt(numberList.Count - 1);
                secondNumber = numberList.ElementAt(numberList.Count - 2);
                additionResult = firstNumber + secondNumber;
                if (additionResult <= maxNumber)
                {
                    numberList.Add(additionResult);
                }
                else
                {
                    stopSearch = true;
                }            
            } while (!stopSearch);
            mtdShowResults(numberList);
        }

        private void mtdShowResults(List<int> numberList)
        {
            string fibonacciList = "";
            foreach (var item in numberList)
            {
                fibonacciList = fibonacciList + " ," + item;
            }
            tbxFibonacciList.Text = fibonacciList;
        }
    }
}
