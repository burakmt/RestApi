using System;
using System.Collections.Generic;
using APIRest.Domain.Customer;
using APIRest.Domain.Discount;

namespace APIRest.Domain
{
	public static class DataSeed
	{
        /// <summary>
        /// Discount in memory datas
        /// </summary>
        /// <returns>Discount list</returns>
		public static IList<Discounts> GeneretaDiscountDatas()
        {
            List<Discounts> discounts = new List<Discounts>();
            discounts.Add(new Discounts(1, 30m,DiscountType.Percent30));
            discounts.Add(new Discounts(2, 10m, DiscountType.Percent10));
            discounts.Add(new Discounts(3, 5m, DiscountType.Percent5));
            discounts.Add(new Discounts(5, 0m, DiscountType.Percent0));
            discounts.Add(new Discounts(4, 5m, DiscountType.Dollar5));

            return discounts;
        }

        public static IList<Customers> GenerateCustomerDatas()
        {
            List<Customers> customers = new List<Customers>();
            customers.Add(new Customers(1, "Burak","Ekici",CustomerType.Employee,DateTime.Now));
            customers.Add(new Customers(2, "Semih", "Zambak", CustomerType.Normal, DateTime.Now));
            customers.Add(new Customers(3, "Burcu", "Yılmaz", CustomerType.Public, DateTime.Now.AddYears(2)));

            return customers;
        }
    }
}

