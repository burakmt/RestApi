using System;
using System.Linq;
using APIRest.Application.Constants.Customer;
using APIRest.Domain;
using APIRest.Domain.Customer;

namespace APIRest.Application.Customer
{
	public class CustomerService : ICustomerService
	{
		public CustomerService()
		{
		}

        public CustomerDto GetCustomer(int id)
        {
			var customers = DataSeed.GenerateCustomerDatas();
			var customer = customers.FirstOrDefault(x => x.Id == id);
			if (customer == null)
				return null;

			return PrepareCustomerEntityToDto(customer);
        }

		public CustomerDto PrepareCustomerEntityToDto(Customers customers)
        {
			CustomerDto dto = new CustomerDto() {
				Name = customers.Name,
				Surname = customers.Surname,
				CustomerType = customers.CustomerType,
				CreateDate = customers.CreateDate
			};

			return dto;
        }
    }
}

