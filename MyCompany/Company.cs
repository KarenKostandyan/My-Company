using System;
namespace MyCompany
{
	public class Company
	{
		Employee[] employees = new Employee[0];
		public Company()
		{

		}

		public void Add(Employee employee)
		{
			Employee[] newArray = new Employee[employees.Length + 1];

			for (int i = 0; i < employees.Length; i++)
			{
				newArray[i] = employees[i];
			}
			newArray[employees.Length] = employee;

			employees= newArray;
		}
		public void RemoveById(int id)
		{
			Employee[] newArray = new Employee[employees.Length - 1];

			for (int i = 0; i <employees.Length; i++)
			{
				if (employees[i].id == id)
				{
					id = i;
					break;
				}
			}

			for (int i = 0; i < id; i++)
			{
				newArray[i] = employees[i];
			}

			for (int i = id+1; i < employees.Length; i++)
			{
				newArray[i - 1] = employees[i];
			}

			employees = newArray;
		}

		public	Employee FindById(int id)
		{
			for (int i = 0; i < employees.Length; i++)
			{
				if (employees[i].id == id)
				{
					return employees[i];
				}
			}
			return null;
		}

		public void Display()
		{
			for (int i = 0; i < employees.Length; i++)
			{
				if (employees[i].IsAvailable == true)
				{
					Console.WriteLine(employees[i]);
				}
				
			}
		}

		public void SentToVacation(int id)
		{
			FindById(id).Rest();
		}

		   
        
    }
}

