using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIRest.Application.Constants.Invoice;
using APIRest.Models.Request;
using APIRest.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        private readonly ILogger<APIController> _logger;

        public APIController(ILogger<APIController> logger, IInvoiceService invoiceService)
        {
            _logger = logger;
            _invoiceService = invoiceService;
        }

        [HttpPost]
        [Route("get-invoice")]
        public BaseResponseModel<decimal> GetInvoice(RequestModel requestModel)
        {
            InvoiceCreateUpdateDto model = new InvoiceCreateUpdateDto()
            {
                TotalAmount = requestModel.TotalAmount,
                ShoppingType = requestModel.ShoppingType,
                CustomerId = requestModel.CustomerId
            };

            var calc = _invoiceService.CreateInvoice(model);
            BaseResponseModel<decimal> response = new BaseResponseModel<decimal>() { Success = true, Data = calc, Date = DateTime.Now };
            return response;
        }

        [HttpGet]
        [Route("test/{id}")]
        public BaseResponseModel<decimal> GetTestInvoice(int id = 1)
        {
            RequestModel requestModel = new RequestModel() {
                CustomerId = id,
                ShoppingType = Domain.Invoice.ShoppingType.Product,
                TotalAmount = 1000
            };

            InvoiceCreateUpdateDto model = new InvoiceCreateUpdateDto() {
                TotalAmount = requestModel.TotalAmount,
                ShoppingType = requestModel.ShoppingType,
                CustomerId = requestModel.CustomerId
            };

            var calc = _invoiceService.CreateInvoice(model);
            BaseResponseModel<decimal> response = new BaseResponseModel<decimal>() { Success = true, Data = calc, Date = DateTime.Now};
            return response;
        }
    }
}

