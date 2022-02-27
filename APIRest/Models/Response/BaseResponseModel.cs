using System;
namespace APIRest.Models.Response
{
	public class BaseResponseModel<T>
	{
        public bool Success { get; set; }
        public T Data { get; set; }
        public DateTime Date { get; set; }
    }
}

