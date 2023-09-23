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
                Console.WriteLine("---------------------------");
                Console.WriteLine("------OOP APPLICATION------");
                Console.WriteLine("---------------------------");

                //Declarar algunas variables
                int day, month, year, id;
                string firstName, lastName, birthDate, hiringDate;
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
                Console.Write("\n");

                Console.WriteLine("Ingrese identificación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre completo: ");
                firstName = Console.ReadLine();

                Console.WriteLine("Ingrese los apellidos: ");
                lastName = Console.ReadLine();

                Console.WriteLine("Ingrese su fecha de cumpleaños: ");
                birthDate = Console.ReadLine();

                Console.WriteLine("Ingrese su fecha de contratación: ");
                hiringDate = Console.ReadLine();

                Console.WriteLine("Are you active? ");
                bool isActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Ingrese el salario devengado: ");
                salary = Convert.ToDecimal (Console.ReadLine());


                Console.WriteLine("******************************");
                Console.WriteLine("******SALARY EMPLOYEE*********");
                Console.WriteLine("******************************");


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



                Console.Write("\n");
                //Console.Clear();
                //Mostramos en pantalla el ToStrin de la clase salaryEmployee
                Console.WriteLine(salaryEmployee.ToString());

                Console.Write("\n");
                //Seteamos las tres nuevas propiedades diferentes a la clase padre
                Console.WriteLine("Ingrese su porcentaje de comisión: ");
                double commissionPercentaje = Convert.ToDouble (Console.ReadLine());
                
                Console.WriteLine("Ingrese el valor de las ventas: ");
                decimal sales = Convert.ToDecimal(Console.ReadLine());


                //salaryEmployee.Id = 1;
                //salaryEmployee.FirstName = firstName;
                //salaryEmployee.LastName = lastName;
                //salaryEmployee.BirthDate = dateObject;
                //salaryEmployee.HiringDate = dateObject;
                //salaryEmployee.IsActive = true;

                Console.Write("\n");
                Console.WriteLine("******************************");
                Console.WriteLine("******COMISSION EMPLOYEE******");
                Console.WriteLine("******************************");

                //Creación objeto
                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = isActive,
                    CommisionPercentaje = commissionPercentaje/100,
                    Sales = sales,

                };

                Console.Write("\n");
                //Console.Clear();
                //Mostramos en pantalla el ToStrin de la clase commissionEmployee
                Console.WriteLine(commissionEmployee.ToString());

            }
            catch (Exception ex)//ex es una variable
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);//Pintamos el mensaje
            }
        }
    }
}
