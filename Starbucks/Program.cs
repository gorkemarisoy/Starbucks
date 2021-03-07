using System;
using System.Dynamic;
using Starbucks.Abstract;
using Starbucks.Adapters;
using Starbucks.Concrete;
using Starbucks.Entities;

//SENERYO
//starbucks ve nero için yazılım
//müşteriler veritabanına kaydedilecek
//starbucks mernis doğrulaması istiyor.
//starbucks kahve alınca yıldız kazandırmak istiyor
//Starbucks da Nero da aynı veritabanına kaydedilip, firmaIdsi ile yönetilecek
namespace Starbucks
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCumtomerManager(new MernisServiceAdapter());    //Burda artık ister Nero ister Starbucks müşterisi gönderebiliriz artık.
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1989,4,9), FirstName = "Abdurrahman Görkem", LastName = "ARISOY", Id = 1, NationalityId = "38422550582"});
            Console.ReadLine();
        }
    }
}
