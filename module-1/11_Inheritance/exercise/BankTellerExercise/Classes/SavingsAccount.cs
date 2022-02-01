namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount () : base() { }

        public SavingsAccount (string acccountHolderName, string accountNumber, decimal balance)
            : base(acccountHolderName, accountNumber, balance) { }



        public override decimal Withdraw(decimal amountToWithdraw)
        {

            if (amountToWithdraw > base.Balance)
            {
                if (base.Balance < 150 && base.Balance > 1)
                {
                    base.Withdraw(2);
                }
                base.Withdraw(0);
            }
            return Balance;

        }
    }
}
