using System;
using System.Runtime.CompilerServices;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Tools;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {



            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            ServiceProductPriceManager priceManager = new ServiceProductPriceManager(new EfServiceProductPriceDal());

            ServiceProductPrice productPrice = new ServiceProductPrice()
            {
                ArizaTespit = 10,
                Iscilik = 10,
                Iskonto = 1,
                Nakliye = 1,
                ServiceProductId = 2,
                ToplamFiyat=20
                
                
            };

            Console.WriteLine(productPrice.ToplamFiyat);
            var a=priceManager.Add(productPrice);

            foreach (var d in a.Data)
            {
                Console.WriteLine(d.Message);

            }



            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(UniqCodeHelper.GenereteUniq());
            //}

            //Console.ReadLine();
            // customerManager.CreatePDF();

            //Address address = new Address() {CityId = 34, DistrictId = 406, Detail = "Valla bilmiyorum yerini"};

            //Customer customer = new Customer()
            //{
            //    Contact = "Taş taşğulları",
            //    CommericalTitle = "Yemek Bekliyor evladı",
            //    CustomerGroupId = 1,
            //    Phone = "4444444",
            //    TaxNumber = "fjjjfjfj"
            //};

            //      var success=_customerDal.AddWithAddress(customer,address);

            // GetCustomerDetail(_customerDal);
            //    ProductServiceTest();
        }

        //private static void GetCustomerDetail(ICustomerService _customerDal)
        //{
        //    var customer = _customerDal.GeyByCustomerDetailWithId(6).Data;
        //    {
        //        Console.WriteLine(customer.CommercialTitle);
        //        Console.WriteLine(customer.District);
        //        Console.WriteLine(customer.CustomerGroup);
        //        Console.WriteLine(customer.City);
        //        Console.WriteLine(customer.Phone);
        //    }
        //}

        //private static void ProductServiceTest()
        //{
        //    IServiceProductDal _product = new EfSerivceProductDal();

        //    _product.Add(new ServiceProduct()
        //    {
        //        AcceptedPersonId = 1,
        //        AcceptedWithProduct = "Ürünle birlikte gelenler",
        //        BrandId = 2,
        //        CustomerId = 1,
        //        Model = "G50",
        //        ProductName = "Ürün adı",
        //        ProductStatus = true,
        //        ServiceTypeId = 5,
        //        SerialNo = "jfjfjfjfjf",
        //        TroubleDescription = "Müşteri beyanı",
        //    });
        //}
    }
}
