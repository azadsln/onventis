using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollService.Model;

namespace PayrollService.Service.PaymentMethods
{
    class Italy :Method, IPayMethod
    {

        public Model.Payment GetPayment(double grossSalary)
        {
           
            double taxRate = 25+ 9.19;
           

            return GetCalculatedPayment(grossSalary, taxRate);
        }
    }
}
