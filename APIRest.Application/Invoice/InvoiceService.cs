using System;
using APIRest.Application.Constants.Discount;
using APIRest.Application.Constants.Invoice;

namespace APIRest.Application.Invoice
{
	public class InvoiceService : IInvoiceService
	{
        private readonly IDiscountService _discountService;
		public InvoiceService(IDiscountService discountService)
		{
            _discountService = discountService;
		}

        public decimal CreateInvoice(InvoiceCreateUpdateDto invoiceCreateUpdateDto)
        {
            decimal discountAmount = 0;
            if(invoiceCreateUpdateDto.ShoppingType == Domain.Invoice.ShoppingType.Product)
            {
                discountAmount = _discountService.GetDiscountPercent(invoiceCreateUpdateDto.CustomerId);
            }

            decimal discount = invoiceCreateUpdateDto.TotalAmount - ((invoiceCreateUpdateDto.TotalAmount * discountAmount) / 100);
            int everyHundredDollar = (int)Math.Floor(discount / 100);
            int dollarDiscount = everyHundredDollar * _discountService.GetDiscountDollar();
            return (discount - dollarDiscount);
        }
    }
}

