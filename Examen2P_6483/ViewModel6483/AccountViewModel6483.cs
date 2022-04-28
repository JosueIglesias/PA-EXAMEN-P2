using Examen2P_6483.Models6483;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen2P_6483.ViewModel6483
{
    public class AccountViewModel6483 : BaseViewModel6483
    {
        #region Properties
        public ObservableCollection<Account6483> AccountsList { get; set; }
        #endregion

        #region Variables
        private Account6483 account;
        public Account6483 Account
        {
            get { return account; }
            set { account = value; OnPropertyChanged(); }
        }
        private User6483 user;
        public User6483 User
        {
            get { return user; }
            set { user = value; OnPropertyChanged(); }
        }
        #endregion

        public ICommand cmdButton { get; set; }
        public ICommand cmdAccountDetail { get; set; }

        public AccountViewModel6483()
        {
           //Tests = new ObservableCollection<Account6483>();

           // Tests.Add(new Account6483 { Name = "PRUEBA" });

            User6483 User = new User6483()
            {
                FirstName = "Josue",
                PaternalLastName = "Iglesias",
                MaternalLastName = "Alcaraz",
                Phone = "3123123124",
                Accounts = new ObservableCollection<Account6483>()
            {
                new Account6483{ Name = "Shopping", AccountNumber = Guid.NewGuid().ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } },
                new Account6483{ Name = "Shopping", AccountNumber = Guid.NewGuid().ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } },
                new Account6483{ Name = "Shopping", AccountNumber = Guid.NewGuid().ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } },
                new Account6483{ Name = "Shopping", AccountNumber = Guid.NewGuid().ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" },
                    new Transaction6483 { Amount = 2000, Date = "27/04/2022", Hour = "13:00" },
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" }
                    } }
            }
            };

            AccountsList = User.Accounts;

            //public ICommand cmdButton { get; set; }
            cmdButton = new Command(async () => await PCmdButton());
            cmdAccountDetail = new Command<Account6483>(async (x) => await PCmdAccountDetail(x));

            #region Commands

            async Task PCmdButton()
            {
                Console.WriteLine(User.Accounts[0].Transactions[0].Amount);
                Console.WriteLine("Hola");
            }

            async Task PCmdAccountDetail(Models6483.Account6483 _Account)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views6483.AccountDetail6483(_Account, this));
            }
            #endregion

        }


    }
}
