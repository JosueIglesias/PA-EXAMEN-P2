using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Examen2P_6483.Triggers6483
{
    public class NewAccountValidationTrigger6483 : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
           var entry = sender as Entry;
           var flag = int.TryParse(entry.Text, out int balance);
            if (balance > 0)
            {
                Console.WriteLine(balance.ToString());
            }
        }
    }
}
