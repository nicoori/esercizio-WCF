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
using ServiceReference1;

namespace ConvertitoreValuteClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ServiceClient service = new ServiceClient();

            ComboDA.ItemsSource = service.getValute();
            ComboDA.DisplayMemberPath = "ValueId";

            ComboA.ItemsSource = service.getValute();
            ComboA.DisplayMemberPath = "ValueId";
        }

        private void ScambioValute_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient service = new ServiceClient();
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient service = new ServiceClient();
        }

        private void TextBox_InserisciNumero(object sender, TextChangedEventArgs e)
        {
            
        }


    }
}
