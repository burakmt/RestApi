using System;
using APIRest.Application.Constants.Discount;
using APIRest.Domain.Invoice;

namespace APIRest.Application.Constants.Invoice
{
	public class InvoiceDto
	{
		/// <summary>
		/// Total amount
		/// </summary>
		public decimal TotalAmount { get; set; }

		/// <summary>
		/// Shopping type
		/// </summary>
		public ShoppingType ShoppingType { get; set; }

    }
}

