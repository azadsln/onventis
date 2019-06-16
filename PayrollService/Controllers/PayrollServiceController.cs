using System;

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using AutoMapper;
using System.Web.Http.Results;
using System.Threading.Tasks;

namespace PayrollService.API.Controllers
{
    
    public class PayrollServiceController : ApiController
    {
        Service.IPayment _payment;
        IMapper _mapper;
        public PayrollServiceController(Service.IPayment payment,IMapper mapper)
        {
            _payment = payment;
            _mapper = mapper;
        }


        [HttpGet]
        public string Get(int hoursWorked, int hourlyRate, string countryCode)
        {
            Model.Payment paymentmodel = _payment.GetPayment(hoursWorked, hourlyRate, countryCode);

            DTO.Payment res = _mapper.Map<DTO.Payment>(paymentmodel);
            return JsonConvert.SerializeObject(res);
        }

    }
}
