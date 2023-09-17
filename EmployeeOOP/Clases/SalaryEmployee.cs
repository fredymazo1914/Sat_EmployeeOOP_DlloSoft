using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Clases
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Methods
        
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t +" +
                $" Salario: {GetValueToPay():C2}";//C de Currency (Money).. el 2 es de 2 decimales
        }

        #endregion

    }
}
