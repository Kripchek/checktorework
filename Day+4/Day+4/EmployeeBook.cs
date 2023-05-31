﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class EmployeeBook
    {
        private static Employee[] Sotrudnik = new Employee[10]
        {
           new Employee("Иванов Иван Иванович", 5, 5000),
           new Employee("Петров Сергей Константинович", 1, 4350),
           new Employee("Лютикова Надежда Петровна", 3, 16700),
           new Employee("Герасимова Любовь Павловна", 4, 4200),
           new Employee("Юн Алия Ахметовна", 1, 8900),
           new Employee("Вьюнков Владислав Владимирович", 2, 15000),
           new Employee("Ким Дамира Дмитревна", 3, 27600),
           new Employee("Сидоров Илья Иванович", 5, 9850),
           new Employee("Крапоткин Виктор Викторович", 4, 10500),
           new Employee("Фомина Анна Олеговна", 2, 9250)
        };
        // Последнее задание тут.По неведомым мне причинам программа не хочет видеть два этих метода в конце.
        public void SalaryLessThanNumber()
        {
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сотрудники с ЗП меньше указанного числа: ");
            foreach (Employee r in Sotrudnik)
            {
                if (chislo > r.Salary)
                {

                    Console.WriteLine($"id сотрудника {r.Id} | ФИО {r.Fio} | Зарплата {r.Salary}");
                }
            }
        }
        public void SalaryMoreThanNumber()
        {
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сотрудники с ЗП больше(или равному) указанного числа: ");
            foreach (Employee r in Sotrudnik)
            {
                if (chislo <= r.Salary)
                {

                    Console.WriteLine($"id сотрудника {r.Id} | ФИО {r.Fio} | Зарплата {r.Salary}");
                }
            }
        }

        public void List_of_employees()
        {
            foreach (Employee a in Sotrudnik)
            {
                if (a != null)
                {
                    Console.WriteLine($"Номер сотрудника: {a.Id} | ФИО: {a.Fio} | Отдел: {a.Department} | Зарплата: {a.Salary}");
                }
            }
            Console.ReadLine();
        }
        public void Sum_salary()
        {
            int totalSalary = 0;
            foreach (Employee b in Sotrudnik)
            {
                totalSalary += b.Salary;
            }
            Console.WriteLine($"Сумма затрат на зп в месяц: {totalSalary}");
            Console.WriteLine();
        }
        public void Min_salary()
        {
            int min = Sotrudnik[0].Salary;
            string name = Sotrudnik[0].Fio;
            foreach (Employee c in Sotrudnik)
            {
                if (c.Salary < min)
                {
                    min = c.Salary;
                    name = c.Fio;
                }
            }
            Console.WriteLine($"У сотрудника {name} самая минимальная зп равная {min}.");
            Console.WriteLine();
        }
        public void Max_salary()
        {
            int max = Sotrudnik[0].Salary;
            string name = Sotrudnik[0].Fio;
            foreach (Employee d in Sotrudnik)
            {
                if (d.Salary > max)
                {
                    max = d.Salary;
                    name = d.Fio;
                }
            }
            Console.WriteLine($"У сотрудника {name} самая мaксимальная зп равная {max}.");
            Console.WriteLine();
        }
        public void Avg_salary()
        {
            int sum = 0;
            int chack = 0;
            foreach (Employee e in Sotrudnik)
            {
                sum += e.Salary;
                chack++;
            }
            Console.WriteLine("Средняя запрлата равна: " + (sum / chack));
            Console.WriteLine();
        }
        public void Fio_employees()
        {
            foreach (Employee f in Sotrudnik)
            {
                if (f != null)
                {
                    Console.WriteLine($"ФИО сотрудников: {f.Fio}");
                }
            }
            Console.ReadLine();
        }
        public void Indexing()
        {
            Console.WriteLine("Введите процент индексации: ");
            int procent = int.Parse(Console.ReadLine());
            int new_salary;
            foreach (Employee w in Sotrudnik)
            {
                new_salary = w.Salary + (w.Salary / procent);
                Console.WriteLine($"ФИО сотрудника: {w.Fio} | Зарплата после индексации: {new_salary}");
            }
        }

        public void Departments()
        {
            Console.WriteLine("Введите номер отдела: ");
            int num_dep = Convert.ToInt32(Console.ReadLine());
            switch (num_dep)
            {
                case 1:
                    Department1_Staff(); Department_1(); Department_1_Index();
                    break;
                case 2:
                    Department2_Staff(); Department_2(); Department_2_Index();
                    break;
                case 3:
                    Department3_Staff(); Department_3(); Department_3_Index();
                    break;
                case 4:
                    Department4_Staff(); Department_4(); Department_4_Index();
                    break;
                case 5:
                    Department5_Staff(); Department_5(); Department_5_Index();
                    break;
            }

            void Department1_Staff()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 1)
                    {
                        Console.WriteLine($"Номер сотрудника: {r.Id} | ФИО: {r.Fio} | Отдел: {r.Department} | Зарплата: {r.Salary}");
                    }
                }
                Console.WriteLine();
            }
            void Department_1()
            {
                int max = Sotrudnik[1].Salary;
                string name1 = Sotrudnik[1].Fio;

                int min = Sotrudnik[1].Salary;
                string name = Sotrudnik[1].Fio;

                int sum_1 = 0;
                int chack_1 = 0;
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 1)
                    {
                        if (r.Salary < min)
                        {
                            min = r.Salary;
                            name = r.Fio;
                        }
                        if (r.Salary > max)
                        {
                            max = r.Salary;
                            name1 = r.Fio;
                        }

                        sum_1 += r.Salary;
                        chack_1++;
                    }
                }
                Console.WriteLine($"У сотрудника {name} самая минимальная зп равная {min}.");
                Console.WriteLine();
                Console.WriteLine($"У сотрудника {name1} самая мaксимальная зп равная {max}.");
                Console.WriteLine();
                Console.WriteLine("Средняя запрлата равна: " + (sum_1 / chack_1));
                Console.WriteLine();
            }
            void Department_1_Index()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 1)
                    {
                        int procent = 2;
                        int new_salary;
                        new_salary = r.Salary + (r.Salary / procent);
                        Console.WriteLine($"ФИО сотрудника: {r.Fio} | Зарплата после индексации: {new_salary}");
                    }
                }
            }

            void Department2_Staff()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 2)
                    {
                        Console.WriteLine($"Номер сотрудника: {r.Id} | ФИО: {r.Fio} | Отдел: {r.Department} | Зарплата: {r.Salary}");
                    }
                }
                Console.WriteLine();
            }
            void Department_2()
            {
                int max_2 = Sotrudnik[9].Salary;
                string name1_2 = Sotrudnik[9].Fio;

                int min_2 = Sotrudnik[9].Salary;
                string name_2 = Sotrudnik[9].Fio;

                int sum_2 = 0;
                int chack_2 = 0;
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 2)
                    {
                        if (r.Salary < min_2)
                        {
                            min_2 = r.Salary;
                            name_2 = r.Fio;
                        }
                        if (r.Salary > max_2)
                        {
                            max_2 = r.Salary;
                            name1_2 = r.Fio;
                        }

                        sum_2 += r.Salary;
                        chack_2++;
                    }
                }
                Console.WriteLine($"У сотрудника {name_2} самая минимальная зп равная {min_2}.");
                Console.WriteLine();
                Console.WriteLine($"У сотрудника {name1_2} самая мaксимальная зп равная {max_2}.");
                Console.WriteLine();
                Console.WriteLine("Средняя запрлата равна: " + (sum_2 / chack_2));
                Console.WriteLine();
            }
            void Department_2_Index()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 2)
                    {
                        int procent = 2;
                        int new_salary;
                        new_salary = r.Salary + (r.Salary / procent);
                        Console.WriteLine($"ФИО сотрудника: {r.Fio} | Зарплата после индексации: {new_salary}");
                    }
                }
            }

            void Department3_Staff()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 3)
                    {
                        Console.WriteLine($"Номер сотрудника: {r.Id} | ФИО: {r.Fio} | Отдел: {r.Department} | Зарплата: {r.Salary}");
                    }
                }
                Console.WriteLine();
            }
            void Department_3()
            {
                int max_3 = Sotrudnik[2].Salary;
                string name1_3 = Sotrudnik[2].Fio;

                int min_3 = Sotrudnik[2].Salary;
                string name_3 = Sotrudnik[2].Fio;

                int sum_3 = 0;
                int chack_3 = 0;
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 3)
                    {
                        if (r.Salary < min_3)
                        {
                            min_3 = r.Salary;
                            name_3 = r.Fio;
                        }
                        if (r.Salary > max_3)
                        {
                            max_3 = r.Salary;
                            name1_3 = r.Fio;
                        }

                        sum_3 += r.Salary;
                        chack_3++;
                    }
                }
                Console.WriteLine($"У сотрудника {name_3} самая минимальная зп равная {min_3}.");
                Console.WriteLine();
                Console.WriteLine($"У сотрудника {name1_3} самая мaксимальная зп равная {max_3}.");
                Console.WriteLine();
                Console.WriteLine("Средняя запрлата равна: " + (sum_3 / chack_3));
                Console.WriteLine();
            }
            void Department_3_Index()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 3)
                    {
                        int procent = 2;
                        int new_salary;
                        new_salary = r.Salary + (r.Salary / procent);
                        Console.WriteLine($"ФИО сотрудника: {r.Fio} | Зарплата после индексации: {new_salary}");
                    }
                }
            }

            void Department4_Staff()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 4)
                    {
                        Console.WriteLine($"Номер сотрудника: {r.Id} | ФИО: {r.Fio} | Отдел: {r.Department} | Зарплата: {r.Salary}");
                    }
                }
                Console.WriteLine();
            }
            void Department_4()
            {
                int max_4 = Sotrudnik[3].Salary;
                string name1_4 = Sotrudnik[3].Fio;

                int min_4 = Sotrudnik[3].Salary;
                string name_4 = Sotrudnik[3].Fio;

                int sum_4 = 0;
                int chack_4 = 0;
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 4)
                    {
                        if (r.Salary < min_4)
                        {
                            min_4 = r.Salary;
                            name_4 = r.Fio;
                        }
                        if (r.Salary > max_4)
                        {
                            max_4 = r.Salary;
                            name1_4 = r.Fio;
                        }

                        sum_4 += r.Salary;
                        chack_4++;
                    }
                }
                Console.WriteLine($"У сотрудника {name_4} самая минимальная зп равная {min_4}.");
                Console.WriteLine();
                Console.WriteLine($"У сотрудника {name1_4} самая мaксимальная зп равная {max_4}.");
                Console.WriteLine();
                Console.WriteLine("Средняя запрлата равна: " + (sum_4 / chack_4));
                Console.WriteLine();
            }
            void Department_4_Index()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 4)
                    {
                        int procent = 2;
                        int new_salary;
                        new_salary = r.Salary + (r.Salary / procent);
                        Console.WriteLine($"ФИО сотрудника: {r.Fio} | Зарплата после индексации: {new_salary}");
                    }
                }
            }

            void Department5_Staff()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 5)
                    {
                        Console.WriteLine($"Номер сотрудника: {r.Id} | ФИО: {r.Fio} | Отдел: {r.Department} | Зарплата: {r.Salary}");
                    }
                }
                Console.WriteLine();
            }
            void Department_5()
            {
                int max_5 = Sotrudnik[0].Salary;
                string name1_5 = Sotrudnik[0].Fio;

                int min_5 = Sotrudnik[0].Salary;
                string name_5 = Sotrudnik[0].Fio;

                int sum_5 = 0;
                int chack_5 = 0;
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 5)
                    {
                        if (r.Salary < min_5)
                        {
                            min_5 = r.Salary;
                            name_5 = r.Fio;
                        }
                        if (r.Salary > max_5)
                        {
                            max_5 = r.Salary;
                            name1_5 = r.Fio;
                        }

                        sum_5 += r.Salary;
                        chack_5++;
                    }
                }
                Console.WriteLine($"У сотрудника {name_5} самая минимальная зп равная {min_5}.");
                Console.WriteLine();
                Console.WriteLine($"У сотрудника {name1_5} самая мaксимальная зп равная {max_5}.");
                Console.WriteLine();
                Console.WriteLine("Средняя запрлата равна: " + (sum_5 / chack_5));
                Console.WriteLine();
            }
            void Department_5_Index()
            {
                foreach (Employee r in Sotrudnik)
                {
                    if (r.Department == 5)
                    {
                        int procent = 2;
                        int new_salary;
                        new_salary = r.Salary + (r.Salary / procent);
                        Console.WriteLine($"ФИО сотрудника: {r.Fio} | Зарплата после индексации: {new_salary}");
                    }
                }
            }
        }
    }
}

