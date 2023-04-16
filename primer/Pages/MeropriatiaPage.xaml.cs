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
    /// Логика взаимодействия для MeropriatiaPage.xaml
    /// </summary>
    public partial class MeropriatiaPage : Page
    {
        public MeropriatiaPage()
        {
            InitializeComponent();

            

            Mer = Core.BD.Meropriatie.ToList();
            
            
            
            Meropriatia.ItemsSource = Mer;
        }

        public List<Meropriatie> Mer { get; set; }

        private void BtnIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
