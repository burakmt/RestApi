using System;
using APIRest.Application.Constants.Customer;
using APIRest.Application.Constants.Discount;
using APIRest.Application.Constants.Invoice;
using APIRest.Application.Customer;
using APIRest.Application.Discount;
using APIRest.Application.Invoice;
using Microsoft.Extensions.DependencyInjection;

namespace APIRest
{
	public static class DependencyRegister
	{
		public static void RegisterServices(this IServiceCollection services)
        {
			services.AddScoped<ICustomerService, CustomerService>();
			services.AddScoped<IDiscountService, DiscountService>();
			services.AddScoped<IInvoiceService, InvoiceService>();
		}
	}
}

