using System;
using APIRest.Domain.Discount;

namespace APIRest.Application.Constants.Discount
{
	public interface IDiscountService
	{
		int GetDiscountDollar();
		decimal GetDiscountPercent(int id);
	}
}

