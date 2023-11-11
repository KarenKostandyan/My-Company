using System;
namespace MyCompany
{
	public class Intern:Employee
	{
		public Intern(string Fullname, int id, DateOnly BirthDay, DateOnly DayOfJoining, DayOff dayoff, decimal? wage = null, bool IsAvailable = true)
			:base(Fullname, id,  BirthDay,  DayOfJoining,  dayoff, wage, IsAvailable)
		{
		}
        public override string ToString()
        {
            return $"Full Name: {Fullname}, " +
                $"ID: {id} " +
                $"Birthday: {BirthDay} " +
                $"Joining Date: {DayOfJoining} " +
                $"Day off: {dayoff} ";
        }
    }
}

