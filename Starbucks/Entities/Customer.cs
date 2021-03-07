using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Abstract;

namespace Starbucks.Entities
{
   public class Customer:IEntity    //customer kayıt edilecek nesne

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
