using System;
using APIRest.Domain.Customer;
using APIRest.Domain.Invoice;

namespace APIRest.Models.Request
{
	public class RequestModel
	{
        /// <summary>
        /// Total amount
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Shopping type
        /// </summary>
        public ShoppingType ShoppingType { get; set; }

        /// <summary>
        /// Customer create date
        /// </summary>
        public int CustomerId { get; set; }
    }
}

