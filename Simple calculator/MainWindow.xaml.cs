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

namespace Simple_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //global variable can be accessed by all methods in this form
        string myChoice = "";
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void cboMathsOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int choice = cboMathsOperation.SelectedIndex;
            if (choice == 1)
            {
                myChoice = "Add";
            }
            if (choice == 2)
            {
                myChoice = "Subtract";
            }
            if (choice == 3)
            {
                myChoice = "Multiply";
            }
            if (choice == 4)
            {
                myChoice = "Divide";
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int firstNo = Convert.ToInt16(tbxFirstNo.Text);
        }
    }
}
