using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Entities;

namespace Starbucks.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService //iki firmanın da ortak yaptığı bir save işi olduğu için base abstract class oluşturduk

    {
        public virtual void Save(Customer customer) //burda virtual koyduğumuz zaman bu kodu ilerde override edebiliriz.
        {                                                                             //burda normalde save kodları yazılacak.
            Console.WriteLine("Müşteri DB'e kaydedildi    :     "+ customer.FirstName);    //herbir Nero or Starbucks customer managerına ayrı ayrı yapabileceğim
        }
    }
}
