using System.ComponentModel.DataAnnotations;

namespace FinanceControl.Domain.DTOs
{
    public class TransactionDTO
    {
        /// <summary>
        /// The type of the financial transaction
        /// C - For positive transaction of money. Example: Salary, Sell of an item, etc.
        /// D - For negative transaction of money. Example: House rent, bills, etc. 
        /// </summary>
        [Required(ErrorMessage = "The type of transaction is required")]
        [RegularExpression("^[C|D|c|d]$", ErrorMessage = "The only types allowed is C - For positive transaction and D - For negative transaction")]
        public char Type { get; set; }

        /// <summary>
        /// Value of the financial transaction
        /// </summary>
        [Required(ErrorMessage = "The value of transaction is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The value of the financial transaction need to be more than 0.01")]
        public decimal Value { get; set; }

        /// <summary>
        /// The category of the transaction. Example: Salary, Electric Bill, etc.
        /// </summary>
        [Required(ErrorMessage = "The category is required")]
        [StringLength(50, ErrorMessage = "The category max length is 50 caracteres")]
        public string Category { get; set; }

        /// <summary>
        /// Every Transaction Data Transfer Object need to be informed only the type, value and the category
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="category"></param>
        public TransactionDTO(char type, decimal value, string category)
        {
            Type = type;
            Value = value;
            Category = category;
        }
    }
}
