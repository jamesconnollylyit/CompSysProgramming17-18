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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        TestEntities db = new TestEntities();
        List<User> userList = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();
            string pass2 = tbxPasswordBox.Password;
            user = VerifyUserDetails(username, password);
            if (user.AccessLevel >0)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Owner = this;
                dashboard.currentUser = user;
                dashboard.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user");
            }

        }

        private User VerifyUserDetails(string username, string password)
        {
            User verifiedUser = new User();
            foreach (var user in userList)
            {
                if (user.UName == username && user.Password == password)
                {
                    verifiedUser = user;
                }
            }
            return verifiedUser;
        }

        private void LoadUsers()
        {
            try
            {
                userList.Clear();
                foreach (var user in db.Users)
                {
                    userList.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database " + ex.InnerException);
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUsers();
        }
    }
}
