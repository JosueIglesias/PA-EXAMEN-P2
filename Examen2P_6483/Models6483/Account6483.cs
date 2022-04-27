using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Examen2P_6483.Models6483
{
    public class Account6483
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
        public ObservableCollection<Transaction6483> Transactions { get; set; }
    }
}
