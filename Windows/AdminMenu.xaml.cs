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
using System.Windows.Shapes;

namespace Project_ekzam.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        ModelBD.Model1 connect = new ModelBD.Model1();
        public AdminMenu()
        {
            InitializeComponent();
            connect.Service.Load();
            list.ItemsSource = connect.Service.Local;
        }

        private void Do_login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow winexit = new MainWindow();
            winexit.Show();
            this.Close();
        }
    }
}
