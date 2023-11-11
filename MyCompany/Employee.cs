using System;
namespace MyCompany
{
	public enum DayOff
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday 
	}

	public class Employee : IAvailable
    {
		public string Fullname { get; set; }
		public int id { get; set; }
		public DateOnly BirthDay { get; set; }
		public decimal? wage { get; set; }
		public DateOnly DayOfJoining { get; set; }
		public DayOff dayoff {get;set;}
		public bool IsAvailable { get; set; }

		public Employee(string Fullname, int id, DateOnly BirthDay, DateOnly DayOfJoining, DayOff dayoff, decimal? wage,  bool IsAvailable=true)
		{
			this.Fullname = Fullname;
			this.id = id;
			this.BirthDay = BirthDay;
			this.wage = wage;
			this.DayOfJoining = DayOfJoining;
			this.dayoff = dayoff;
			this.IsAvailable = IsAvailable;
		}
        public override string ToString()
        {
			return $"Full Name: {Fullname}, " +
				$"ID: {id}, " +
				$"Birthday: {BirthDay}, " +
				$"Wage: {wage}, " +
				$"Joining Date: {DayOfJoining}, " +
				$"Day off: {dayoff} ";
        }

		public void Rest()
		{
            IsAvailable = false;
		}
    }
}

