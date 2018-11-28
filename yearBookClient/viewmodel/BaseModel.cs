using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace yearBookClient.viewmodel {
    public class BaseModel : INotifyPropertyChanged{

    public event PropertyChangedEventHandler PropertyChanged;
    protected void onPropertyChanged([CallerMemberName]string propertyName = ""){

      if (this.PropertyChanged != null){

        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
