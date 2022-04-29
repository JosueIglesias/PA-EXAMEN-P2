using Examen2P_6483.Models6483;
using System;
using System.Collections.ObjectModel;
using System.Linq;
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

        private Transaction6483 transaction;
        public Transaction6483 Transaction
        {
            get { return transaction; }
            set { transaction = value; OnPropertyChanged(); }
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
        public ICommand cmdNewAccount { get; set; }
        public ICommand cmdAddAccount { get; set; }
        public ICommand cmdDeposit { get; set; }
        public ICommand cmdWithdrawal { get; set; }
        public ICommand cmdDepositTransaction { get; set; }
        public ICommand cmdWithdrawalTransaction { get; set; }
        public ICommand cmdDeleteAccount { get; set; }
        public ICommand cmdRegister { get; set; }
        public ICommand cmdProfileEditionPage { get; set; }
        public ICommand cmdUpdateProfileInfo { get; set; }
        


        public AccountViewModel6483()
        {
            #region
            /*
            User6483 User = new User6483()
            {
                FirstName = "Josue",
                PaternalLastName = "Iglesias",
                MaternalLastName = "Alcaraz",
                Phone = "3123123124",
                Accounts = new ObservableCollection<Account6483>()
            {
                new Account6483{ Name = "Shopping1", AccountNumber = new Random().Next(1000, 9999).ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } },
                new Account6483{ Name = "Shopping2", AccountNumber = new Random().Next(1000, 9999).ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } },
                new Account6483{ Name = "Shopping3", AccountNumber = new Random().Next(1000, 9999).ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } },
                new Account6483{ Name = "Shopping4", AccountNumber = new Random().Next(1000, 9999).ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" },
                    new Transaction6483 { Amount = 2000, Date = "27/04/2022", Hour = "13:00" },
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" }
                    } }
            }
            };*/
            #endregion

            User6483 RegisteredUser = new User6483();
            RegisteredUser.FirstName = "PRUEBA";
            

            cmdNewAccount = new Command(async () => await PCmdNewAccount());
            cmdAccountDetail = new Command<Account6483>(async (x) => await PCmdAccountDetail(x));
            cmdAddAccount = new Command<Account6483>(async (x) => await PCmdAddAccount(x));
            cmdDeleteAccount = new Command<Account6483>(async (x) => await PCmdDeleteAccount(x));
            cmdDeposit = new Command(async () => await PCmdDeposit());
            cmdWithdrawal = new Command(async () => await PCmdWithdrawal());
            cmdDepositTransaction = new Command<Transaction6483>(async (x) => await PCmdDepositTransaction(x));
            cmdWithdrawalTransaction = new Command<Transaction6483>(async (x) => await PCmdWithdrawalTransaction(x));
            cmdRegister = new Command<User6483>(async (x) => await PCmdRegister(x));
            cmdProfileEditionPage = new Command(async () => await PCmdProfileEditionPage());
            cmdUpdateProfileInfo = new Command<User6483>(async (x) => await PCmdUpdateProfileInfo(x));

            #region Commands

            async Task PCmdRegister(Models6483.User6483 _User)
            {
                Console.WriteLine(_User.FirstName);

                //User6483 User = new User6483()
                //{
                //    FirstName = _User.FirstName,
                //    PaternalLastName = _User.PaternalLastName,
                //    MaternalLastName = _User.MaternalLastName,
                //    Phone = _User.Phone,
                //    Accounts = new ObservableCollection<Account6483>()
                //};

                RegisteredUser.FirstName = _User.FirstName;
                RegisteredUser.PaternalLastName = _User.PaternalLastName;
                RegisteredUser.MaternalLastName = _User.MaternalLastName;
                RegisteredUser.Phone = _User.Phone;
                RegisteredUser.Accounts = new ObservableCollection<Account6483>();
                AccountsList = RegisteredUser.Accounts;

                Console.WriteLine(_User.FirstName);
                //await Application.Current.MainPage.Navigation.PushAsync(new Views6483.MainPage6483(this));
                Application.Current.MainPage = new NavigationPage(new Views6483.MainPage6483(this));



            }

            async Task PCmdUpdateProfileInfo(Models6483.User6483 _User)
            {
                RegisteredUser.FirstName = _User.FirstName;
                RegisteredUser.PaternalLastName = _User.PaternalLastName;
                RegisteredUser.MaternalLastName = _User.MaternalLastName;
                RegisteredUser.Phone = _User.Phone;

                await Application.Current.MainPage.Navigation.PopAsync();
            }

            async Task PCmdProfileEditionPage()
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views6483.EditProfile6483(this));

            }

            async Task PCmdAccountDetail(Models6483.Account6483 _Account)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views6483.AccountDetail6483(_Account, this));
            }

            async Task PCmdNewAccount()
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views6483.NewAccount6483(this));

            }

            async Task PCmdAddAccount(Models6483.Account6483 _Account)
            {
                if (_Account.Balance > 0)
                {
                    RegisteredUser.Accounts.Add(_Account);
                    AccountsList = RegisteredUser.Accounts;
                    Console.WriteLine("Cuenta Añadida");

                    await Application.Current.MainPage.Navigation.PopAsync();
                }
            }

            async Task PCmdDeleteAccount(Models6483.Account6483 _Account)
            {
                Console.WriteLine(RegisteredUser.Accounts[0].Balance);
                Console.WriteLine(AccountsList[0].Balance);

                if (_Account.Balance == 0)
                {
                    RegisteredUser.Accounts.Remove(_Account);
                    AccountsList = RegisteredUser.Accounts;

                    OnPropertyChanged();


                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                
            }

            async Task PCmdDeposit()
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views6483.NewTransaction6483("Deposit", Account, this));
            }

            async Task PCmdWithdrawal()
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views6483.NewTransaction6483("Withdrawal", Account, this));
            }

            async Task PCmdDepositTransaction(Models6483.Transaction6483 _Transaction)
            {
                if (_Transaction.Amount > 0)
                {
                    DateTime actualDate = DateTime.Now;

                    _Transaction.Date = actualDate.ToString("d");
                    _Transaction.Hour = actualDate.ToString("t");

                    if (Account.Transactions == null)
                    {
                        Account.Transactions = new ObservableCollection<Transaction6483>();
                    }
                    var index = -1;
                    Account6483 tmp = RegisteredUser.Accounts.FirstOrDefault(a => a.AccountNumber == Account.AccountNumber);
                    if (tmp != null)
                    {
                        Account.Transactions.Add(_Transaction);
                        Account.Balance += _Transaction.Amount;
                        index = RegisteredUser.Accounts.IndexOf(tmp);
                        RegisteredUser.Accounts[index] = Account;
                    }

                    OnPropertyChanged();

                    await Application.Current.MainPage.Navigation.PopAsync();
                    await Application.Current.MainPage.Navigation.PopAsync();

                }

            }

            async Task PCmdWithdrawalTransaction(Models6483.Transaction6483 _Transaction)
            {
                if (_Transaction.Amount <= Account.Balance)
                {
                    DateTime actualDate = DateTime.Now;

                    _Transaction.Date = actualDate.ToString("d");
                    _Transaction.Hour = actualDate.ToString("t");

                    if (Account.Transactions == null)
                    {
                        Account.Transactions = new ObservableCollection<Transaction6483>();
                    }
                    var index = -1;
                    Account6483 tmp = RegisteredUser.Accounts.FirstOrDefault(a => a.AccountNumber == Account.AccountNumber);
                    if (tmp != null)
                    {
                        Account.Transactions.Add(_Transaction);
                        Account.Balance -= _Transaction.Amount;
                        index = RegisteredUser.Accounts.IndexOf(tmp);
                        RegisteredUser.Accounts[index] = Account;
                    }

                    OnPropertyChanged();

                    
                    await Application.Current.MainPage.Navigation.PopAsync();
                    await Application.Current.MainPage.Navigation.PopAsync();
                }

                
            }
            #endregion

        }

        
    }
}
