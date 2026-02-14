using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask12thFeb.Models
{
	internal class Person
	{
		private string _name;
		private string _surname;
		public int Age;

		public string Name 
		{
			get 
			{
				return _name;
			}
			set
			{
				if (String.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Enter Name!!!");
					return;
				}
				if (!Char.IsUpper(value[0]))
				{
					Console.WriteLine("Name must be in uppercase!");
					return;
				}
				if (value.Trim().Length < 3 || value.Trim().Length > 30)
				{
					Console.WriteLine("Name cant be in that length! (Must be in beetween 3 and 30.)");
					return;
				}
				_name = value;
			} 
		}
		public string Surname 
		{
			get
			{
				return _surname;
			}
			set
			{
				if (String.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Enter Surname!!!");
					return;
				}
				if (!Char.IsUpper(value[0]))
				{
					Console.WriteLine("Surname must be in uppercase!");
					return;
				}
				if (value.Trim().Length<3 || value.Trim().Length>35)
				{
					Console.WriteLine("Surname cant be in that length! (Must be in beetween 3 and 35.)");
					return;
				}
				_surname = value;
			}
		}

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void FullName()
		{
			Console.WriteLine($"Fullname ==> {Name} {Surname}");
		}

	}
}
