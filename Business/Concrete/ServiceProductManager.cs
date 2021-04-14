
using System;
using System.Collections.Generic;
using System.Transactions;
using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Tools;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class ServiceProductManager:IServiceProductService
    {
        private readonly IServiceProductDal _serviceProduct;
        private readonly ICustomerService _customerService;

        public ServiceProductManager(IServiceProductDal serviceProduct,ICustomerService customerService)
        {
            _serviceProduct = serviceProduct;
            _customerService = customerService;
        }


        public IResult Add(ServiceProduct serviceProduct)
        {

            serviceProduct.SpecialCode = UniqCodeHelper.GenereteUniq();
            _serviceProduct.Add(serviceProduct);
            return new SuccessResult();

        }

        public IDataResult<List<ServiceProduct>> GetAll()
        {
            return new SuccessDataResult<List<ServiceProduct>>(_serviceProduct.GetAll());

        }

        public IResult AddwithCustomer(ServiceProduct serviceProduct, Customer customer)
        {

            var result = _customerService.AddOutId(customer);
            serviceProduct.CustomerId = result.Data.Id;
            serviceProduct.SpecialCode = UniqCodeHelper.GenereteUniq();
            _serviceProduct.Add(serviceProduct);
            return new SuccessResult();
        }
    }
}