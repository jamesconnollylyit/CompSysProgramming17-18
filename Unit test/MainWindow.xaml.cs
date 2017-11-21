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
        public MainWindow()
        {
            InitializeComponent();
        }



       private int AddTwoNumbers (int firstNumber, int secondNumber)
        {
            int total = 0;
            total = firstNumber + secondNumber;
            return total;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt16(tbxFirstNumber.Text);
            int secondNumber = Convert.ToInt16(tbxSecondNumber.Text);
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
    }
}
