using EmployeeOPP.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Clases
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal GetValueToPay();
        //Esta clase no tiene código, el código de ir en las clases que heredan de esta clase abstracta

        public override string ToString()
        {
            //Concatenación por interpolación
            return $"INFORMACIÓN DEL EMPLEADO \n\t " +
                $"ID: {Id} \n\t " +
                $"Nombres: {FirstName} \n\t " +
                $"Apellidos: {LastName} \n\t " +
                $"Fecha de cumpleaños: {BirthDate} \n\t " +
                $"Fecha de Contratación: {HiringDate} \n\t " +
                $"¿Empleado Activo?: {IsActive}";

        }

        #endregion







    }
}
