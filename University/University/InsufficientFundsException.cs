namespace University
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
            : base("Error: Insufficient funds for this transaction.") { }

        public InsufficientFundsException(string message)
            : base(message) { }

    }
}
