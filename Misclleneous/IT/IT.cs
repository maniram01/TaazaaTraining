namespace Misclleneous.IT
{
    public class Taazaa
    {
        double Salary;
        readonly int Empid; // ony declare by constructor
        static string Cafetaria;

        public Taazaa(int eid,double sal) //
        {
            Salary=sal;
            Empid=eid;
        }
        static Taazaa()
        {
            Cafetaria="100 sqft";
        }
        public int Employeeid() // member Function
        {
            return Empid;
        }
        public static string Coffeehouse()  // static Function
        {
            return Cafetaria;
        }
        public double EmployeeSalary() // member Function
        {
            return Salary;
        }
    }
}