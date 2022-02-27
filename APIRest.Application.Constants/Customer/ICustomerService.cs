using System;
using APIRest.Domain.Customer;

namespace APIRest.Application.Constants.Customer
{
	public interface ICustomerService
	{
		CustomerDto GetCustomer(int id);
	}
}

