using CoffyShop.Abstract;
using CoffyShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoffyShop.Concrete
{
	public class StarbucksCustomerManager:BaseCustomerManager
	{
		private ICustomerCheckService _customerCheckService;
		public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
		{
			_customerCheckService = customerCheckService;
		}
		
		public override void Save(Customer customer)
		{
			if (_customerCheckService.CheckIfRealPerson(customer))
			{
				base.Save(customer);
			}
			
			else
			{
                Console.WriteLine("Kullanıcı bulunamadı.");
			}
			
		}

		
	}
}
