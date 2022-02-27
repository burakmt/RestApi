using System;
namespace APIRest.Domain.Invoice
{
	public class Invoices : BaseEntity
	{
		/// <summary>
        /// Total amount
        /// </summary>
		public decimal TotalAmount { get; set; }

		/// <summary>
        /// Shopping type value
        /// </summary>
		public int ShoppingTypeValue { get; set; }

		/// <summary>
        /// Shopping type
        /// </summary>
		public ShoppingType ShoppingType
		{
			get => (ShoppingType)ShoppingTypeValue;
			set => ShoppingTypeValue = (int)value;
		}

		/// <summary>
        /// Ctor
        /// </summary>
        /// <param name="totalAmount">Total amount</param>
		public Invoices(int id, decimal totalAmount) : base(id)
		{
			TotalAmount = totalAmount;
		}
	}
}

