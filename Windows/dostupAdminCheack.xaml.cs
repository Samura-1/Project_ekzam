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

namespace Project_ekzam.Windows
{
    /// <summary>
    /// Логика взаимодействия для dostupAdminCheack.xaml
    /// </summary>
    public partial class dostupAdminCheack : Window
    {
        public dostupAdminCheack()
        {
            InitializeComponent();
        }

        private void Do_login_Click(object sender, RoutedEventArgs e)
        {
            if (TpasswordCode.Password == "0000")
            {
                MainWindow.dostup = "Admin_code";
                Windows.AdminMenu winmenu = new Windows.AdminMenu();
                winmenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не верный Код!");
            }
        }

        private void Do_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow autback = new MainWindow();
            autback.Show();
            this.Close();
        }
    }
}
