namespace BankTellerExercise.Classes
{
    public class BankAccount
    {

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }  //USD
        
        
        public BankAccount (string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            Balance = 0;
        }

        public BankAccount (string acccountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = acccountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance; 
        }

        public BankAccount()
        {

        }

        public decimal Deposit (decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw (decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }

    }
}
