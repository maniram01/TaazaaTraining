namespace day6.Models
{
    internal class Employee
    {
       private int Eid;
        private double Salary;

        public int Employeeid // Properties
        {
            get // Access
            {
                return Eid;

            }
            set // Assign
            {
                Eid=value; // value is reserved keyword to assign the data to variable

            }

        }
        public double EmployeeSalary // Properties
        {
            get // Access
            {
                return Salary;

            }
            set // Assign
            {
                Salary=value; // value is reserved keyword to assign the data to variable

            }

        }

    }
}