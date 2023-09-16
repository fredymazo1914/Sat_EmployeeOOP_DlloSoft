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
                int day, month, year;

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
            }
            catch (Exception ex)//ex es una variable
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);//Pintamos el mensaje
            }
        }
    }
}
