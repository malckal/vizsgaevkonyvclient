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
using yearBookClient.viewmodel;

namespace yearBookClient.view {
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page {
        private MainWindow win = (MainWindow)Application.Current.MainWindow;
        public MainMenu() {
            InitializeComponent();
        }

        private void ClassListClick(object sender, RoutedEventArgs e) {
            win.OnSchoolClassGetAll();
            ((MainWindowViewModel)Application.Current.MainWindow.DataContext).CurrentPage = new ClassList();
        }

        private void StudentClick(object sender, RoutedEventArgs e) {
            win.OnStudentGetAll();
        }
    }
}
