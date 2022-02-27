using System;
namespace APIRest.Application.Constants.Invoice
{
	public class InvoiceCreateUpdateDto : InvoiceDto
	{
        public int CustomerId { get; set; }
    }
}

