using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollService.Service.PaymentMethods
{
    class Method
    {        
        protected Model.Payment  GetCalculatedPayment (double grossSalary ,double  taxRate)
        {
            Model.Payment payment = new Model.Payment();
            payment.GrossSalary = grossSalary;
            payment.TaxesDeductions = grossSalary * taxRate / 100;
            payment.NetSalary = grossSalary - payment.TaxesDeductions;

            return payment;
        }
    }
}
