using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollService.Service.PaymentMethods
{
    /// <summary>
    /// the
    /// </summary>
    interface IPayMethod
    {
        /// <summary>
        /// Calculate the payment by gross salary.
        /// </summary>
        /// <param name="grossSalary"></param>
        /// <returns>an Payment object that shows the payment details</returns>
        Model.Payment GetPayment(double grossSalary);
    }
}
