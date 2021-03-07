using System;
using System.Collections.Generic;
using System.Text;
using Starbucks.Entities;

namespace Starbucks.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer );  //her iki firma da kayıt işlemi istiyor zaten ondan save ortak
                                        //ikisinde de olduğu için Save metodu soyutlandı (abstract)
                                        //bu interfacei çağıran herkes bu operasyonu yapacak
    }
}
