using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EmployeeOOP.Clases
{
    public class CommissionEmployee : Employee
    {

        #region Properties

        public double CommisionPercentaje { get; set; }

        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission Percentage.....{CommisionPercentaje}\n\t" +
                $"Sales.....{Sales}\n\t" +
                $"Value to Pay..... {GetValueToPay()}";
        }

        #endregion

    }
}