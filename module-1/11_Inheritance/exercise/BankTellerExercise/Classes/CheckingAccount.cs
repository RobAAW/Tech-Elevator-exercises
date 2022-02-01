namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount() : base() { }

        public CheckingAccount(string acccountHolderName, string accountNumber, decimal balance)
            : base(acccountHolderName, accountNumber, balance) { }

        
        
    public override decimal Withdraw(decimal amountToWithdraw)
        {
      
            if (Balance > -100)
            {
                if (Balance < 0)
                {
                    base.Withdraw(10);
                }
                base.Withdraw(amountToWithdraw);
            }
            return Balance;

        }

    }
}
