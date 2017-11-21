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

namespace Unit_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstNumber = 0;
        int secondNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }



       public int AddTwoNumbers (int firstNumber, int secondNumber)
        {
            int total = 0;
            if (firstNumber <0 || secondNumber < 0)
            {
                return -1;
            }          
            total = firstNumber + secondNumber;
            return firstNumber + secondNumber;
        }

        public void btnAdd_Click(object sender, RoutedEventArgs e)
        {           
            int result = AddTwoNumbers(firstNumber, secondNumber);
            DisplayResult(result);
        }

        private void DisplayResult(int total)
        {
            tbxTotal.Text = Convert.ToString(total);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbxFirstNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            firstNumber = Convert.ToInt16(tbxFirstNumber.Text);
        }

        private void tbxSecondNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            secondNumber = Convert.ToInt16(tbxSecondNumber.Text);
        }
    }
}
