using System;
using APIRest.Domain.Customer;
using APIRest.Domain.Discount;

namespace APIRest.Application.Constants.Discount
{
	public class DiscountDto
    {
        /// <summary>
        /// Discount amount
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Discount type
        /// </summary>
        public DiscountType DiscountType { get; set; }

        /// <summary>
        /// Customer type
        /// </summary>
        public int CustomerId { get; set; }
    }
}

