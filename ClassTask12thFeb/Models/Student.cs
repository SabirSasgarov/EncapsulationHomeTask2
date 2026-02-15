using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassTask12thFeb.Models
{
	internal class Student : Person
	{
		private int _point;
		private string _groupNumber;

		public int Point
		{
			get
			{
				return _point;
			}
			set
			{
				if (value < 0 || value > 100)
				{
					Console.WriteLine($"Point cant be {value}! (0-100)");
					return;
				}
				_point = value;
			}
		}
		public string GroupNumber
		{
			get
			{
				return _groupNumber;
			}
			set 
			{
				if (value.Length > 4)
				{
					Console.WriteLine("Length of group name can not be longer that 4! (P202)");
					return;
				}
				if (!Char.IsLetter(value[0]) || !Char.IsUpper(value[0]))
				{
					Console.WriteLine("First character can not be a non-letter(uppercase) value! (P202)");
					return;
				}
				for(int i = 1; i<value.Length;i++) 
				{
					if (!Char.IsDigit(value[i]))
					{
						Console.WriteLine("You need to add 3 digits after uppercase letter! (P202)");
						return;
					}
				}
				_groupNumber = value;
			}
		}

		public Student(string name, int age, int point) : base(name, age)
		{
			Point = point;
		}




	}
}
