using System.Windows.Controls;
using yearBookClient.view;

namespace yearBookClient.viewmodel {
    public class MainWindowViewModel : BaseModel{
        private Page currentPage;

        public Page CurrentPage { get => currentPage; set {
                if (value != null && value != currentPage) {
                    currentPage = value;
                    onPropertyChanged("CurrentPage");
                } else
                    return;
            }
        }




        public MainWindowViewModel() {
            currentPage = new MainMenu();
        }
    }
}
