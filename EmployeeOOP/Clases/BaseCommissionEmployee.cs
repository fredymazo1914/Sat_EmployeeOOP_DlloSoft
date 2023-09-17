using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Clases
{
    public class BaseCommissionEmployee : CommissionEmployee
    {

        #region Properties

        public decimal Base { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }
}
