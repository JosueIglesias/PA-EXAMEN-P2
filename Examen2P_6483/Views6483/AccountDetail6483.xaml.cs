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
    public partial class AccountDetail6483 : ContentPage
    {
        public AccountDetail6483(Models6483.Account6483 account, AccountViewModel6483 vm)
        {
            InitializeComponent();
            vm.Account = new Models6483.Account6483();
            vm.Account = account;
            this.BindingContext = vm;
        }
    }
}