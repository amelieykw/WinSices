using System;
using System.Collections;

namespace WinSices02_ConsolePROJ
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			Console.WriteLine(dog.Describe());
			Console.ReadKey();
		}
	}

	abstract class FourLeggedAnimal
	{
		public virtual string Describe()
		{
			return "Not much is known about this four legged animal!";
		}
	}

	class Dog : FourLeggedAnimal
	{
		public override string Describe()
		{
			string result = base.Describe();
			result += " In fact, it's a dog!";
			return result;
		}
	}
}
