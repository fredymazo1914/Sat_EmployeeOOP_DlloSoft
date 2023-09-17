using EmployeeOOP.Clases;
using EmployeeOPP.Clases;
using System;

namespace EmployeeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Controlar exepciones
            try
            {
                Console.WriteLine("OOP APPLICATION");
                Console.WriteLine("---------------");

                //Declarar algunas variables
                int day, month, year, id;
                string firstName, lastName;
                decimal salary;

                Console.Write("Ingresar el día: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes: ");
                //Todo lo que entra a ReadLine(), llega como String, para otro tipo de dato se debe hacer conversión
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año: ");
                year = Convert.ToInt32(Console.ReadLine());

                //Instaciar la clase Date (crear el objeto)
                Date dateObject = new Date(year, month, day);
                Console.Write("\n");//Salto de línea
                Console.WriteLine(dateObject.ToString());

                Console.WriteLine("Ingrese identificacióno: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre completo: ");
                firstName = Console.ReadLine();

                Console.WriteLine("Ingrese los apellidos: ");
                lastName = Console.ReadLine();

                Console.WriteLine("Ingrese el salario devengado: ");
                salary = Convert.ToDecimal (Console.ReadLine());

                //Esta es la forma de crear objetos a partir de una clase concreta
                SalaryEmployee salaryEmployee = new SalaryEmployee()
                {
                    //Se hace set (asignar) a cada una de las propiedades
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = salary,
                };

                Console.Clear();
                Console.WriteLine(salaryEmployee); 

                //
                //salaryEmployee.Id = 1;
                //salaryEmployee.FirstName = firstName;
                //salaryEmployee.LastName = lastName;
                //salaryEmployee.BirthDate = dateObject;
                //salaryEmployee.HiringDate = dateObject;
                //salaryEmployee.IsActive = true;





            }
            catch (Exception ex)//ex es una variable
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);//Pintamos el mensaje
            }
        }
    }
}
