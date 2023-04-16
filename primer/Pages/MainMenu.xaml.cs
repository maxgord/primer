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

namespace primer.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();


        }



        private void BtnToReg_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox==null||LoginBox==null)
            {
                MessageBox.Show("Пароль или логин не введен!","Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var User = Core.BD.Polzovateli.ToList();
            var UserVr = User.FirstOrDefault(u => u.Login.ToLower() == LoginBox.Text.ToLower() || u.Parol == PasswordBox.Password );

             if (UserVr != null)
            {
                MessageBox.Show("Успешно");
                switch (UserVr.Rol)
                {
                    case 1:
                    this.NavigationService.Navigate(new Pages.MeropriatiaPage());
                        break;
                    case 2:
                    this.NavigationService.Navigate(new Pages.ModersPage());
                        break;
                    case 3:
                    this.NavigationService.Navigate(new Pages.OrganizatrPage(UserVr));
                        break;
                    case 4:
                    this.NavigationService.Navigate(new Pages.JuriPage());
                        break;
                        
                }

                
                
            }
        }

        private void BtnToNReg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.MeropriatiaPage());
        }
    }
}
