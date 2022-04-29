using Examen2P_6483.ViewModel6483;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2P_6483.Views6483
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfile6483 : ContentPage
    {
        public EditProfile6483(AccountViewModel6483 vm)
        {
            InitializeComponent();
            vm.User = vm.User;
            //vm.User.Accounts = new System.Collections.ObjectModel.ObservableCollection<Models6483.Account6483>();
            BindingContext = vm;
        }
    }
}