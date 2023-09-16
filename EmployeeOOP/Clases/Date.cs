using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOPP.Clases
{
    public class Date
    {
        #region Fields
        //atributos
        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        //Método constructor
        public Date(int year, int month, int day)
        {
            //se inicializan los campos
            _year = ValidateYear(year);
            _month = ValidateMonth(month);//Se llama el método ValidateMonth y se le envía month
            _day = ValidateDay(day, month, year);
        }

        private int ValidateDay(int day, int month, int year)
        {
            //Valido si el día pertenece a un año bisiesto
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
                        
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }
                        
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                throw new DayException(String.Format("El día {0} no es valido para el mes {1}", day, month));
            }
        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (!isLeapYear)//Un booleano se niega anteponiendo !
            {
                throw new YearException(String.Format("El año {0} no es bisiesto!", year));
            }
        }

        private bool IsLeapYear(int year)
        {
            bool IsLeapYear = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            return IsLeapYear;
        }

        

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                throw new YearException(String.Format("El año {0} no es valido!", year));
            }
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)//Falso
            {
                return month;
            }
            else
            {
                throw new MonthException(String.Format("El mes {0} no es valido!", month));
            }
        }

        //Se llama el método ToString pero con override se le da un comportamiento diferente
        public override string ToString()
        {
            //Tres formas de concatenar
            var dateConcatenated1 = _day + "/" + _month + "/" + _year;
            var dateConcatenated2 = ($"{_day:00}/{_month:00}/{_year:0000}"); //Interpolación
            var dateConcatenated3 = String.Format("{0:00}/{1:00}/{2:0000}", _day, _month, _year);//Clase String.Format()
            return dateConcatenated3;
        }

        #endregion
    }
}
