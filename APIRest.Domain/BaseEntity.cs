using System;
namespace APIRest.Domain
{
	public abstract class BaseEntity
	{
        public int Id { get; set; }

        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}

