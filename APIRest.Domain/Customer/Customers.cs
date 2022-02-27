using System;
namespace APIRest.Domain.Customer
{
	public class Customers : BaseEntity
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
        /// Customer type value
        /// </summary>
        public int CustomerTypeValue { get; set; }

        /// <summary>
        /// Customer type 
        /// </summary>
        public CustomerType CustomerType
        {
            get => (CustomerType)CustomerTypeValue;
            set => CustomerTypeValue = (int)value;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="customerType">Type</param>
        /// <param name="createDate">Create date</param>
        public Customers(
            int id,
            string name,
            string surname,
            CustomerType customerType,
            DateTime createDate) : base(id)
        {
            Name = name;
            Surname = surname;
            CustomerType = customerType;
            CreateDate = createDate;
        }
    }
}

