using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollService.Model;

namespace PayrollService.Service.PaymentMethods
{
    class Spain :Method,  IPayMethod
    {
        public Model.Payment GetPayment(double grossSalary)
        {
            int taxRate = 4;
            if (grossSalary <= 500)
            {
                taxRate += 25 + 7;
            }
            else if(grossSalary >500 && grossSalary <= 600)
            {
                taxRate += 25 + 8;
             }
            else 
            {
                taxRate += 40+8;
            }


            return GetCalculatedPayment(grossSalary, taxRate);
        }
    }
}
