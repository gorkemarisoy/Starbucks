using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Abstract;
using Starbucks.Entities;

namespace Starbucks.Concrete
{
   public class NeroCustomerManager:BaseCustomerManager //:ICustomerService yapabilirdik ama Neroda Starbucksda aynı kodu kullanacağı için ayrı yapmaya gerek yok. 
                                                        //Dolayısı ile BaseCustomerManager abstractını ürettik
   {
   }
}
