using System;

namespace Day_4
{
    public class Program
    {
        

        static void Main(string[] args)
        { 
            Console.WriteLine("Введите букву задания: ");
            string word = Console.ReadLine();
            switch (word)
            {
                case "a":
                    EmployeeBook.List_of_employees();
                    break;
                case "b":
                    EmployeeBook.Sum_salary();
                    break;
                case "c":
                    EmployeeBook.Min_salary();
                    break;
                case "d":
                    EmployeeBook.Max_salary();
                    break;
                case "e":
                    EmployeeBook.Avg_salary();
                    break;
                case "f":
                    EmployeeBook.Fio_employees();
                    break;
                default:
                    Console.WriteLine("Введите правильное значение.");
                    break;
            }
            Console.WriteLine("Введите номер задания: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    EmployeeBook.Indexing();
                    break;
                case 2:
                    EmployeeBook.Departments();
                    break;
                case 3:
                    EmployeeBook.SalaryLessThanNumber();
                    EmployeeBook.SalaryMoreThanNumber();
                    break;  
            }

            
            
        }
    }
}