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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public User currentUser;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowButtons(currentUser.AccessLevel);
        }

        private void ShowButtons(int accessLevel)
        {
            if (accessLevel == 1)
            {
                btnAdmin.Visibility = Visibility.Visible;
                btnNewItem.Visibility = Visibility.Visible;
                btnNormalUser.Visibility = Visibility.Visible;
            }
        }
    }
}
