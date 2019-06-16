using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollService.Model
{
    public class Payment
    {
        public string CountryCode { get; set; }
        public double GrossSalary { get; set; }
        public double TaxesDeductions { get; set; }
        public double NetSalary { get; set; }
    }
}
