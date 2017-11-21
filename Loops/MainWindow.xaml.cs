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

namespace Loops
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int answer = Convert.ToInt16(tbxScore.Text.Trim());
                if (answer == 100)
                {
                    MessageBox.Show("Well done");
                }
                else if (answer >=90)
                {
                    MessageBox.Show("You got an A");
                }
                else if (answer >= 80)
                {
                    MessageBox.Show("You got a B");
                }
                else if (answer >= 70)
                {
                    MessageBox.Show("You got an C");
                }
                else if (answer < 60)
                {
                    MessageBox.Show("You got an F");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Problem with your number");
            }

            

        }
    }
}
