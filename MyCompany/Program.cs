namespace MyCompany;

class Program
{
    static void Main(string[] args)
    {
        Company company = new Company();
        Intern intern1 = new Intern("John Doe", 12345, new DateOnly(1998,5,15), new DateOnly(2023, 11, 1), DayOff.Saturday, 1200.00M);
        Intern intern2 = new Intern("Frank Smith", 12322, new DateOnly(2001, 6, 5), new DateOnly(2023, 11, 1), DayOff.Saturday, 1000.00M);
        Employee employee1 = new Employee("Gilbert Gates", 12882, new DateOnly(2001, 6, 5), new DateOnly(2023, 11, 1), DayOff.Saturday, 1100.00M);

        company.Add(intern1);
        company.Add(intern2);
        company.Add(employee1);



        //Console.WriteLine(company.FindById(12882)); 
          //company.SentToVacation(12882);
       // company.RemoveById(12345);

        company.Display();


       
    
        /*Console.WriteLine("Create your worker:");

        Console.WriteLine("Full name off the employee");
        string name=Console.ReadLine();

        Console.WriteLine("Id:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Birtday (format: yyyy-mm-dd)");
        string birthday = Console.ReadLine();
        DateOnly Birthday = DateOnly.Parse(birthday);

        Console.WriteLine("Salary");
        decimal wage = int.Parse(Console.ReadLine());

        Console.WriteLine("The first day at work  (format: yyyy-mm-dd)");
        string joiningday = Console.ReadLine();
        DateOnly JoiningDay = DateOnly.Parse(joiningday);

        Console.WriteLine("Day that He/She is off(start with Capital lettetr)");
        string enumString = Console.ReadLine();
        DayOff DayOff = (DayOff)Enum.Parse(typeof(DayOff), enumString);

        Employee employee = new Employee(name, id, Birthday, JoiningDay, DayOff, wage);
        Console.WriteLine(employee);*/

    }
}

