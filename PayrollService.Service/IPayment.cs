using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollService.Service
{
    public interface IPayment
    {
        Model.Payment GetPayment(int hoursWorked, int hourlyRate,string countryCode);
    }
}
