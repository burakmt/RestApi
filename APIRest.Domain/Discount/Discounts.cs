using System;
using System.Collections.Generic;
using APIRest.Domain.Customer;

namespace APIRest.Domain.Discount
{
	public class Discounts : BaseEntity
    {
        /// <summary>
        /// Discount amount
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Discount type value
        /// </summary>
        public int DiscountTypeValue { get; set; }

        /// <summary>
        /// Discount type
        /// </summary>
        public DiscountType DiscountType
        {
            get => (DiscountType)DiscountTypeValue;
            set => DiscountTypeValue = (int)value;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="discountAmount">Discount amount</param>
        /// <param name="discountType">Type</param>
        public Discounts(
            int id,
            decimal discountAmount,
            DiscountType discountType) : base(id)
        {
            DiscountAmount = discountAmount;
            DiscountType = discountType;
        }
    }
}

