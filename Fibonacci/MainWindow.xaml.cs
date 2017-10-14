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
    /// In a fibonacci series, the next number is the sum of previous two numbers
    /// For example 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 etc.
    /// The first two numbers of fibonacci series are 0 and 1
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
            //Maximum number we want the fibonacci sequence to continue to
            int maxNumber = Convert.ToInt16( tbxMaxFibonacciNumber.Text.Trim());
            //Add two default numbers in fibonacci sequence
            numberList.Add(0);
            numberList.Add(1);        
            do
            {
                //First number from list of fibonacci numbers
                firstNumber = numberList.ElementAt(numberList.Count - 1);
                //Second number from list of fibonacci numbers
                secondNumber = numberList.ElementAt(numberList.Count - 2);
                //Addition of two last numbers from fibonacci numbers
                additionResult = firstNumber + secondNumber;
                //Check nad makse sure the addition result is less than the maximum
                //number we typed into our text box
                if (additionResult <= maxNumber)
                {
                    //Add the addition of last two numbers to the list
                    numberList.Add(additionResult);
                }
                else
                {
                    //Dont add the two numbers, and exit the loop
                    stopSearch = true;
                }            
            } while (!stopSearch);
            mtdShowResults(numberList);
        }

        private void mtdShowResults(List<int> numberList)
        {
            //This string is used to build a list of all items in the number list
            //created in the "Generate" button click event
            string fibonacciList = "";
            foreach (var item in numberList)
            {
                //the list consists of each number separated by a comma
                fibonacciList = fibonacciList + " ," + item;
            }
            //Once the list is built, show it in the textbox
            tbxFibonacciList.Text = fibonacciList;
        }
    }
}
