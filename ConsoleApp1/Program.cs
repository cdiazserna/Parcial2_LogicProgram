using System;
using System.Collections.Generic;

namespace PersonaPOO
{
    public class Person
    {
        // Sección de Propiedades
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearBirth { get; set; }
        public int MonthBirth { get; set; }
        public int DayBirth { get; set; }



        // Método Constructor
        public Person(string firstName, string lastName, int yearBirth, int monthBirth, int dayBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearBirth = yearBirth;
            MonthBirth = monthBirth;
            DayBirth = dayBirth;
        }

        // Métodos
        public int CalculateAge()
        {
            DateTime birthDate = new DateTime(YearBirth, MonthBirth, DayBirth);
            DateTime currentDate = DateTime.Now;

            // Validar si la fecha de nacimiento es válida y menor o igual a la fecha actual
            if (birthDate <= currentDate)
            {
                int age = currentDate.Year - YearBirth;

                // Comprobar si el cumpleaños ya ha ocurrido este año
                if (birthDate.AddYears(age) > currentDate)
                {
                    age--;
                }

                return age;
            }
            else
            {
                Console.WriteLine("La fecha de nacimiento ingresada es inválida.");
                return -1;
            }
        }

        public void ShowPersonInfo()
        {
            int age = CalculateAge();
            if (age >= 0)
            {
                Console.WriteLine($"Nombre completo: {FirstName} {LastName}");
                Console.WriteLine($"Edad: {age} años");
            }
        }
    }
}
