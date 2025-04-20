namespace FinanceControl.Domain.Entities
{
    public class Transaction
    {
        /// <summary>
        /// Global Unique ID for every transaction
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The type of the financial transaction
        /// C - For positive transaction of money. Example: Salary, Sell of an item, etc.
        /// D - For negative transaction of money. Example: House rent, bills, etc. 
        /// </summary>
        public char Type { get; set; }

        /// <summary>
        /// Value of the financial transaction
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// The category of the transaction. Example: Salary, Electric Bill, etc.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The date of registration of the financial transaction
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        public Transaction(char type, decimal value, string category)
        {
            DateTime now = DateTime.Now;
            ID = Guid.NewGuid();
            Type = type;
            Value = value;
            Category = category;
            RegistrationDate = now.AddMilliseconds(-now.Millisecond);
        }
    }
}
