using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollService.Service.PaymentMethods
{
    /// <summary>
    /// This class is a factory that chooses the proper 
    /// method for calculating the net income
    /// </summary>
    class PayCalculator
    {
        IPayMethod _payMethod;
        string _countryCodel;
        /// <summary>
        /// Select the appropriate payment method
        /// </summary>
        /// <param name="countryCode">Country ISO Code</param>
        public PayCalculator(string countryCode)
        {
            _countryCodel = countryCode;
            switch(_countryCodel.ToLower())
            {
                case "esp":
                    _payMethod = new Spain();
                    break;
                case "ita":
                    _payMethod = new Italy();
                    break;
                default:
                    _payMethod = new Germany();
                    break;
            }
        }

        /// <summary>
        /// Return the payment details
        /// </summary>
        /// <param name="hoursWorked">working hours</param>
        /// <param name="hourlyRate">rate per hour</param>
        /// <returns></returns>
        public  Model.Payment GetPayment(int hoursWorked, int hourlyRate)
        {
            int grossSalary = hourlyRate * hoursWorked;
            Model.Payment payment= _payMethod.GetPayment(grossSalary);
            payment.CountryCode = _countryCodel;
            return payment;
        }
    }
}
