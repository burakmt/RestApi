using System;
using System.Linq;
using APIRest.Application.Constants.Customer;
using APIRest.Application.Constants.Discount;
using APIRest.Domain;
using APIRest.Domain.Discount;

namespace APIRest.Application.Discount
{
	public class DiscountService : IDiscountService
	{
        private readonly ICustomerService _customerService;

		public DiscountService(ICustomerService customerService)
		{
            _customerService = customerService;
		}

        public int GetDiscountDollar()
        {
            var discounts = DataSeed.GeneretaDiscountDatas();
            return (int)discounts.FirstOrDefault(x => x.DiscountType == DiscountType.Dollar5).DiscountAmount;
        }

		public decimal GetDiscountPercent(int id)
        {
			var discounts = DataSeed.GeneretaDiscountDatas();
            var customer = _customerService.GetCustomer(id);
            Discounts changeDiscount = discounts.FirstOrDefault(x => x.DiscountType == DiscountType.Percent0);

            if (DateTime.Now.Year - customer.CreateDate.Year >= 2)
                changeDiscount = discounts.FirstOrDefault(x => x.DiscountType == DiscountType.Percent5);

            switch (customer.CustomerType)
            {
                case Domain.Customer.CustomerType.Employee:
                    changeDiscount = discounts.FirstOrDefault(x => x.DiscountType == DiscountType.Percent30);
                    break;
                case Domain.Customer.CustomerType.Normal:
                    changeDiscount = discounts.FirstOrDefault(x => x.DiscountType == DiscountType.Percent10);
                    break;
                default:
                    break;
            }

            return changeDiscount.DiscountAmount;
        }
	}
}

