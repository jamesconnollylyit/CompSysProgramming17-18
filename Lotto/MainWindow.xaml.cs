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

namespace Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] lottoNumbers = new int[7];
        int maxNumberRange = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIrishLotto_Click(object sender, RoutedEventArgs e)
        {
            maxNumberRange = 52;
            mtdStartApplication();
        }

        private void btnUKLotto_Click(object sender, RoutedEventArgs e)
        {
            maxNumberRange = 59;
            mtdStartApplication();
        }

        private void mtdStartApplication()
        {
      
            int arrayPosition = 0;
            int randomNumber = 0;
            do
            {
                randomNumber = mtdGenerateRandomNumber();
                bool exists = mtdCheckIfNumberExists(randomNumber);
                if (exists == false)
                {
                    lottoNumbers[arrayPosition] = randomNumber;
                    ++arrayPosition;
                }

            } while (arrayPosition < lottoNumbers.Length);
            mtdDisplayResults();
        }

        private int mtdGenerateRandomNumber()
        {
            int number = 0;
            Random random = new Random();
            number = random.Next(1, maxNumberRange);
            return number;
        }

        private bool mtdCheckIfNumberExists(int newNumber)
        {
            bool exists = false;
            foreach (var number in lottoNumbers)
            {
                if (number == newNumber)
                {
                    exists = true;
                }
            }
            return exists;
        }

        private void mtdDisplayResults()
        {
            tbxResult1.Text = lottoNumbers[0].ToString();
            tbxResult2.Text = lottoNumbers[1].ToString();
            tbxResult3.Text = lottoNumbers[2].ToString();
            tbxResult4.Text = lottoNumbers[3].ToString();
            tbxResult5.Text = lottoNumbers[4].ToString();
            tbxResult6.Text = lottoNumbers[5].ToString();
        }
    }


}
