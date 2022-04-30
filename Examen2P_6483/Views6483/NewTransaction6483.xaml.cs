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
    public partial class NewTransaction6483 : ContentPage
    {
        public NewTransaction6483(string TransactionType, Models6483.Account6483 account, AccountViewModel6483 vm)
        {
            InitializeComponent();

            vm.Account = new Models6483.Account6483();
            vm.Account.Transactions = new System.Collections.ObjectModel.ObservableCollection<Models6483.Transaction6483>();
            vm.Transaction = new Models6483.Transaction6483();

            vm.Account = account;
            BindingContext = vm;

            if (TransactionType == "Deposit")
            {
                ImageTransaction.Source = new Uri("https://uxwing.com/wp-content/themes/uxwing/download/16-banking-finance/deposit.png");
                ImageTransaction.HeightRequest = 200;
                Console.WriteLine("Deposit");
                AccountName.Text = "Deposit amount";
                BtnWithdrawal.IsVisible = false;
                vm.Transaction.Type = "Deposit";
                
            }

            if (TransactionType == "Withdrawal")
            {
                ImageTransaction.Source = new Uri("https://cdn-icons-png.flaticon.com/512/1682/1682308.png");
                ImageTransaction.HeightRequest = 200;
                Console.WriteLine("Withdrawal");
                AccountName.Text = "Withdraw amount";
                BtnDeposit.IsVisible = false;
                vm.Transaction.Type = "Withdrawal";

            }
        }
    }
}