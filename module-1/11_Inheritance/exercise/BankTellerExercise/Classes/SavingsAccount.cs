namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount () : base() { }

        public SavingsAccount (string acccountHolderName, string accountNumber, decimal balance)
            : base(acccountHolderName, accountNumber, balance) { }



        public override decimal Withdraw(decimal amountToWithdraw)
        {


            decimal serviceCharge = 2;

            if (amountToWithdraw > base.Balance)
            {
                base.Withdraw(0);
            }
            else
                base.Withdraw(amountToWithdraw);

            if (base.Balance < 150 && base.Balance > 1)
            {
                base.Withdraw(serviceCharge);
            }
            return Balance;

        }
    }
}
