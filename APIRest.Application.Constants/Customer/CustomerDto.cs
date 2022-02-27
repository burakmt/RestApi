using System;
using APIRest.Domain.Customer;

namespace APIRest.Application.Constants.Customer
{
	public class CustomerDto
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Customer type 
        /// </summary>
        public CustomerType CustomerType { get; set; }
    }
}

