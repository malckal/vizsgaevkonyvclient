using System;

namespace yearBookClient.viewmodel {
    public class MainMenuViewModel : BaseModel {
        private String text;



        public MainMenuViewModel() {
            Text = String.Empty;
        }

        public string Text { get => text; set {
                text = value;
                onPropertyChanged("Text");
            }
        }
    }
}
