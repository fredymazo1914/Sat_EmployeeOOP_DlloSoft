using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Clases
{
    public class HourtyEmployee : Employee
    {

        #region Properties

        public DateTime Hours { get; set; }

        public int HourValue  { get; set; }

        public override decimal GetValueToPay()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Methods

        #endregion

    }
}
