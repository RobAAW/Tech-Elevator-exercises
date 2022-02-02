using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer
    {
        private List<IAccountable> accounts = new List<IAccountable>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                if (accounts[0].Balance + accounts[1].Balance + accounts[2].Balance == 25000)
                {
                    return true;
                }
                return false;
            }
        }

        public void AddAccount (IAccountable newAccount)
        {
            accounts.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            IAccountable[] accountArray = new IAccountable[accounts.Count];
            accounts.CopyTo(accountArray);
            return accountArray;
        }

    }
}
