using Examen2P_6483.Models6483;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace Examen2P_6483.ViewModel6483
{
    public class AccountViewModel6483 : BaseViewModel6483
    {
        #region Properties
        public ObservableCollection<Account6483> Accounts { get; set; }
        #endregion

        #region Variables
        private Account6483 _account;
        public Account6483 account
        {
            get { return _account; }
            set { _account = value; OnPropertyChanged(); }
        }
        private User6483 _user;
        public User6483 user
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged(); }
        }
        #endregion

        User6483 User = new User6483()
        {
            FirstName = "Josue",
            PaternalLastName = "Iglesias",
            MaternalLastName = "Alcaraz",
            Phone = "3123123124",
            Accounts = new ObservableCollection<Account6483>()
            {
                new Account6483{ Name = "Shopping", AccountNumber = Guid.NewGuid().ToString(), Balance = 5000, Transactions = new ObservableCollection<Transaction6483>(){
                    new Transaction6483 { Amount = 1000, Date = "27/04/2022", Hour = "13:00" } } }
            }
        };


    }
}
