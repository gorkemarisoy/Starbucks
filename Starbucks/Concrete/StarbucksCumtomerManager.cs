using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Abstract;
using Starbucks.Entities;

namespace Starbucks.Concrete
{
    public class StarbucksCumtomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCumtomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) //save metodunu override ederek mernis kontrolünü ekledik.
        {
            if (_customerCheckService.CheckIfRealPerson(customer))//gerçek insan olduğuna emin olmak istiyodu
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
             //

        }
        //yarın Nero da isterse mernis check diye abstract içine Interface oluşturuyoz
        //private void CheckIfRealPerson(Customer customer)
        //{
        //    throw new NotImplementedException(); 

        //}
    }
}
