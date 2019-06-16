using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollService.Model;

namespace PayrollService.Service.PaymentMethods
{
    class Germany :Method, IPayMethod
    {

        public Model.Payment GetPayment(double grossSalary)
        {
           
            double taxRate = 2;
            if (grossSalary <= 400)
            {
                taxRate += 25;
            }
            else
            {
                taxRate += 32;
            }

            return GetCalculatedPayment(grossSalary, taxRate);
        }
    }
}
