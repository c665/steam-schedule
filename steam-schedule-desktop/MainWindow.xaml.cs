using ControlzEx.Standard;
using MahApps.Metro.Controls;
using steam_schedule_desktop.Domain.SteamUri;
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


namespace steam_schedule_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Steam _steam;

        public MainWindow()
        {
            InitializeComponent();
            _steam = new Steam();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _steam.SetStatusInvisible();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _steam.SetStatusOnline();
        }
    }
}
