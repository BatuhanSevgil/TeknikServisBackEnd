using System;
using System.Runtime.CompilerServices;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //ICustomerService customerService = new CustomerManager(new EfCustomerDal());

            ////customerService.Add(new Customer()
            ////{
            ////    CommericalTitle = "Batuhan",
            ////    Contact = "Batuhan Sevgil",
            ////    CustomerAddress = new CustomerAddress() { AddressDetails = "Blabla", CityId = 34, DistrictId = 2 },
            ////    Phone = "5551253",
            ////    CustomerGroupId = 4
            ////});

            //Console.WriteLine(customerService.GetByCustomerId(4).Data.Contact);



            IServiceProductDal _product = new EfSerivceProductDal();

            _product.Add(new ServiceProduct()
            {
                AcceptedPersonId = 1,
                AcceptedWithProduct = "Ürünle birlikte gelenler",
                BrandId = 2,
                CustomerId = 1,
                Model = "G50",
                ProductName = "Ürün adı",
                ProductStatus = true,
                ServiceTypeId = 5,
                SerialNo = "jfjfjfjfjf",
                TroubleDescription = "Müşteri beyanı",
            });

        }
    }
}
