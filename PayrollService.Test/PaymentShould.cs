using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollService;
namespace PayrollService.Test
{
    [TestClass]
    public class PaymentShould
    {
        [TestMethod]
        [DataRow(20, 10, "deu", 200.0, 54.0, 146.0)]
        [DataRow(20, 10, "esp", 200.0, 72.0, 128.0)]
        [DataRow(20, 10, "ita", 200.0, 68.38, 131.62)]
        [DataRow(40, 13, "deu", 520.0, 176.8,343.2)]
        [DataRow(40, 13, "esp", 520.0, 192.4, 327.6)]
        public void ReturnCorrectPaymentForEachCountry(int hoursWorked, int hourlyRate, string countryCode,
                                                       double grossSalary, double taxesDeductions, double netSalary)
        {
            Service.IPayment paymentService = new Service.Payment();

            Model.Payment payment = paymentService.GetPayment(hoursWorked, hourlyRate, countryCode);

            Assert.AreEqual(grossSalary, payment.GrossSalary);
            Assert.AreEqual(taxesDeductions, payment.TaxesDeductions);
            Assert.AreEqual(netSalary, payment.NetSalary);
        }

    }
}
