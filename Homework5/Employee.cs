using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal class Employee
    {
        int id;
        float salary;
        /// <summary>
        /// Идентификационный номер работника.
        /// </summary>
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Номер должен быть положительным!");
                id = value;
            }
        }
        /// <summary>
        /// Зарплата работника.
        /// </summary>
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Зарплата не может быть отрицательной!");
                salary = value;
            }
        }
        /// <summary>
        /// Имя работника.
        /// </summary>
        public string Name { get; set; } = "Ivan";
        /// <summary>
        /// Должность работника.
        /// </summary>
        public string Post { get; set; } = "Worker";
        /// <summary>
        /// Отдел работника.
        /// </summary>
        public string Department { get; set; } = "Earth";

        #region Construct
        public Employee()
        {
            ID = 1;
            Salary = 0;
            Name = "Ivan";
            Post = "Worker";
            Department = "Earth";
        }
        public Employee(int Id, float sal)
        {
            ID = Id;
            Salary = sal;
            Name = "Ivan";
            Post = "Worker";
            Department = "Earth";
        }
        /// <summary>
        /// Расширенный конструктор работника.
        /// </summary>
        /// <param name="Id">Идентификационный номер.</param>
        /// <param name="sal">Зарплата работника.</param>
        /// <param name="name">Имя работника.</param>
        /// <param name="post">Должность.</param>
        /// <param name="department">Отдел работника.</param>
        public Employee(int Id, float sal, string name, string post, string department)
        {
            ID = Id;
            Salary = sal;
            Name = name ?? "Ivan";
            Post = post ?? "Worker";
            Department = department ?? "Earth";
        }
        #endregion

        public override string ToString()
        {
            return "ID: " + ID + "\n" +
                "Name: " + Name + "\n" +
                "Department: " + Department + "\n" +
                "Post: " + Post + "\n" +
                "Salary: " + Salary + "\n";
        }
    }
}
