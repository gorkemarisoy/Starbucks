using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Abstract;
using Starbucks.Entities;

namespace Starbucks.Concrete
{
   public class CustomerCheckManager:ICustomerCheckService //
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true; // bu bizim kendi servisimiz test için kullanabiliriz.
        }
    }

   
}
