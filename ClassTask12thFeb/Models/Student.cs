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


		public Student(string name, int age, int point) : base(name, age)
		{
			Point = point;
		}

		


	}
}
