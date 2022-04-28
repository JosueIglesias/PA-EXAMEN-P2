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
        public NewTransaction6483(string TransactionType)
        {
            InitializeComponent();
        }
    }
}