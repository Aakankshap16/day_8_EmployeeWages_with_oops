namespace EmployeeWagesProblemWithuseObj
{
    class Program
    {
        public static void Main(string[] args) 
        {
            // Compute Employee wages for multiple Company

            Console.WriteLine("Enter the name of the company Dmart or Relince:");
            string company = Console.ReadLine();

            EmployeeWageCode obj = new EmployeeWageCode();
            if (company == "Dmart")
            {
                obj.ComputeEmpWage(company, 20, 10, 90);
            }
            else if (company == "Relince") { obj.ComputeEmpWage(company, 20, 10, 90); }
            else { Console.WriteLine("Please enter correct company!!"); }
        }
    }
}