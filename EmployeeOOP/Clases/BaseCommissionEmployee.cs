using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Clases
{
    public class BaseCommissionEmployee : CommissionEmployee
    {

        #region Properties

        public decimal Base { get; set; }
        public float CommissionPercentaje { get; internal set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base................{Base:C2}";
        }

        #endregion

    }
}
