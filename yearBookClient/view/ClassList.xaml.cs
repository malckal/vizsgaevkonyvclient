using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using yearBookClient.model;
using yearBookClient.viewmodel;

namespace yearBookClient.view {
    /// <summary>
    /// Interaction logic for ClassList.xaml
    /// </summary>
    public partial class ClassList : Page {
        private MainWindow win = (MainWindow)Application.Current.MainWindow;
        public ClassList() {
            InitializeComponent();           
        }



        private void OpenClass(object sender, MouseButtonEventArgs e)
        {
            SchoolClass chosenClass = (SchoolClass)((ListView)sender).SelectedItem;
            win.OnSchoolClassGetOne(chosenClass.ClassName);
            ((MainWindowViewModel)win.DataContext).CurrentPage = new StudentList();

        }
    }
}
