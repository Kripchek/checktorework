using System;

namespace Day_4
{
    internal class Program
    {
        

        static void Main(string[] args)
        { 
            Console.WriteLine("Введите букву задания: ");
            string word = Console.ReadLine();
            switch (word)
            {
                case "a":
                    List_of_employees();
                    break;
                case "b":
                    Sum_salary();
                    break;
                case "c":
                    Min_salary();
                    break;
                case "d":
                    Max_salary();
                    break;
                case "e":
                    Avg_salary();
                    break;
                case "f":
                    Fio_employees();
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
                    Indexing();
                    break;
                case 2:
                    Departments();
                    break;
                case 3:
                    SalaryLessThanNumber();
                    SalaryMoreThanNumber();
                    break;
            }

            
            }
        }
    }
}