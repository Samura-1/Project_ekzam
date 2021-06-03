using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Project_ekzam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ModelBD.Model1 connect = new ModelBD.Model1();
        public MainWindow()
        {
            InitializeComponent();
            dostup = null;
            connect.users.Load();
        }
        static public string dostup;

        private void Do_login_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)checkAdmin.IsChecked)
            {
                dostup = "Admin_code";
                Windows.dostupAdminCheack winmenu = new Windows.dostupAdminCheack();
                winmenu.Show();
                this.Close();
            }
            else if(connect.users.Local.Where(x=> x.login == TLoginUser.Text && x.password == TpasswordUSer.Password).FirstOrDefault() != null)
            {
                dostup = connect.users.Local.Where(x => x.login == TLoginUser.Text && x.password == TpasswordUSer.Password).FirstOrDefault().login;
                Windows.MenuPage winmenu = new Windows.MenuPage();
                winmenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не верный Логин или пароль!");
            }
        }
    }
}
