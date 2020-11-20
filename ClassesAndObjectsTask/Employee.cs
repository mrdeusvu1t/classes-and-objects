using System;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        private string GetEmployeeAge() => age.ToString();

        public void ChangeEmployeeSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string InfoEmployee() => $"Surname: {surname}, Age: {age}";
    }
}
