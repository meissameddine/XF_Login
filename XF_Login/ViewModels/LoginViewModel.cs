/**using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace XF_Login.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

       // public ObservableCollection<Covid> Medal { get; set; }


        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string evaxId;
        public string EvaxId
        {
            get { return evaxId; }
            set
            {
                evaxId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EvaxId"));
            }
        }
        private string cin;
        public string Cin
        {
            get { return cin; }
            set
            {
                cin = value;
                PropertyChanged(this, new PropertyChangedEventArgs("cin"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (evaxId != "macoratti@yahoo.com" || cin != "secret")
            {
                DisplayInvalidLoginPrompt();
            }
        }


      


    }
}
**/