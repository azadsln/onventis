using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollService.Model;

namespace PayrollService.Service
{

    public class Payment : IPayment
    {
        PaymentMethods.PayCalculator _paymentcalculator;

        /// <summary>
        /// Return payment details for a specific country
        /// </summary>
        /// <param name="hoursWorked">whole of work which done per hour</param>
        /// <param name="hourlyRate">rate per hour</param>
        /// <param name="countryCode">Country ISO Code</param>
        /// <returns> an Payment object that shows a payment detail</returns>
        public  Model.Payment GetPayment(int hoursWorked, int hourlyRate, string countryCode)
        {
            _paymentcalculator = new PaymentMethods.PayCalculator(countryCode);
            return  _paymentcalculator.GetPayment(hoursWorked, hourlyRate);
        }
    }
}
