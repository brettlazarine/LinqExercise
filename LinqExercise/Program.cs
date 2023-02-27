using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE  TODO: Print the Sum of numbers
            Console.WriteLine($"Sum: {numbers.Sum()}");

            //DONE  TODO: Print the Average of numbers
            Console.WriteLine("**********");
            Console.WriteLine($"Average: {numbers.Average()}");

            //DONE  TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("**********");
            Console.WriteLine($"Ascending: ");
            var asc = numbers.OrderBy( x => x );
            foreach (var num in asc)
            {
                Console.WriteLine(num);
            }

            //DONE  TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("**********");
            Console.WriteLine("Descending: ");
            var desc = numbers.OrderByDescending( num => num );
            foreach (var num in desc)
            {
                Console.WriteLine(num);
            }

            //DONE  TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("**********");
            Console.WriteLine("Greater than 6: ");
            var sixOrMore = numbers.Where( num => num > 6 );
            foreach (var num in sixOrMore) {Console.WriteLine(num); }

            //DONE  TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("**********");
            Console.WriteLine("Print 4: ");
            var four = numbers.OrderBy(num => num).Take(4);
            foreach (var num in four) { Console.WriteLine(num); }
            //DONE  TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("**********");
            Console.WriteLine("My age: ");
            numbers[4] = 31;
            var myAge = numbers.OrderByDescending(num => num); ;
            foreach (var num in myAge)
            { Console.WriteLine(num); }
            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE  TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("**********");
            Console.WriteLine("First names C or S: ");
            var cOrS = employees.Where(emp => emp.FirstName[0] == 'C' || emp.FirstName[0] == 'S').OrderBy(emp => emp.FirstName);
            foreach (var emp in cOrS)
            {
                Console.WriteLine(emp.FullName);
            }
            //DONE  TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("**********");
            Console.WriteLine("Over 26: ");
            var over26 = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            foreach (var emp in over26) { Console.WriteLine($"{emp.FullName}, {emp.Age} years old"); }

            //DONE  TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("**********");
            Console.WriteLine("YOE sum and average: ");
            var yOE = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35).Select(emp => emp.YearsOfExperience);
            Console.WriteLine($"Sum: {yOE.Sum()}, Average: {yOE.Average()}");
            //DONE  TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("**********");
            Console.WriteLine("Don't use Add(): ");
            var newEmp = new Employee("Brett", "Lazarine", 31, 0);
            employees = employees.Append(newEmp).ToList(); 
            foreach (var emp in employees) { Console.WriteLine(emp.FullName); }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
