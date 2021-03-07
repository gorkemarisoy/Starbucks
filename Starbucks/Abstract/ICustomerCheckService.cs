using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Entities;

namespace Starbucks.Abstract
{
    public interface ICustomerCheckService

    {
        bool CheckIfRealPerson(Customer customer); //true or false gelsin
    }
}
