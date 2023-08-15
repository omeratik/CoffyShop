using CoffyShop.Abstract;
using CoffyShop.Adapters;
using CoffyShop.Concrete;
using System.Diagnostics;

namespace CoffyShop
{
	public class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
			
			customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(2001,9,28), FirstName="ömer",LastName="atik",NationalityId="23143556302" });
			Console.ReadLine();
		}

	}
}