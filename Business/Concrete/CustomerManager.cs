using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Transactions;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Concrete.DTOs;
using FastReport;
using Newtonsoft.Json;
using FastReport.Export.PdfSimple;
namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _CustomerDal;
        private Report report = new Report();


        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;

        }

        public IDataResult<CustomerDetailDto> GetByCustomerDetailWithId(int customerId)
        {
            return new SuccessDataResult<CustomerDetailDto>(_CustomerDal.GeyByCustomerDetailWithId(customerId));

        }



        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_CustomerDal.GetAll());
        }

        //[Aspect]]
        public IResult Add(Customer customer)
        {

            _CustomerDal.Add(customer);
            return new SuccessResult();

        }

        public IResult Update(Customer customer)
        {
            _CustomerDal.Update(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _CustomerDal.Delete(customer);
            return new SuccessResult();

        }

        public IDataResult<Customer> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Customer>(_CustomerDal.Get(customer => customer.Id == customerId));
        }

        public IDataResult<Customer> AddOutId(Customer customer)
        {
            var result = _CustomerDal.AddOutEntity(customer);
            return new SuccessDataResult<Customer>(result);
        }

        public void CreatePDF()
        {
            var customer = _CustomerDal.GetAll();


            report.Load(@"C:\Users\B\source\repos\TeknikServisBackEnd\Business\Reports\report.frx");
            report.RegisterData(customer, "customer");
            report.Prepare();
            report.SavePrepared(@"C:\Users\B\source\repos\TeknikServisBackEnd\Business\Reports\new.frx");
            PDFSimpleExport pdfSimple = new PDFSimpleExport();
            pdfSimple.Export(report,"asde.pdf");


        }

    }
}
