using System;
namespace APIRest.Application.Constants.Invoice
{
	public interface IInvoiceService
	{
		decimal CreateInvoice(InvoiceCreateUpdateDto invoiceCreateUpdateDto);
	}
}

