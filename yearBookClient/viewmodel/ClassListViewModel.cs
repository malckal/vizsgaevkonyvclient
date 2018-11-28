using System.Collections.ObjectModel;
using System.Windows;
using yearBookClient.model;
using yearBookClient.view;

namespace yearBookClient.viewmodel {
    public class ClassListViewModel : BaseModel {
        private ObservableCollection<SchoolClass> classList;

        public ObservableCollection<SchoolClass> ClassList {
            get {
                return classList;
            }

            set {
                classList = value;
                onPropertyChanged("ClassList");
            }
        }

        public ClassListViewModel() {
            ((MainWindow)Application.Current.MainWindow).OnSchoolClassGetAll();
            ClassList = new ObservableCollection<SchoolClass>(MainWindow.SchoolClassResponseList);
        }
    }
}
