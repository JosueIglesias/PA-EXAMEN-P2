using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Examen2P_6483.Models6483
{
    public class User6483
    {
        public string FirstName { get; set; }
        public string PaternalLastName { get; set; }
        public string MaternalLastName { get; set; }
        public string Phone { get; set; }
        public ObservableCollection<Account6483> Accounts { get; set; }
    }
}
