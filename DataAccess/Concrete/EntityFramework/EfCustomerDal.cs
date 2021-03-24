using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Transactions;
using Core.Utilities.Results;
using Entity.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfRepositoryBase<Customer, TeknikServisContext>, ICustomerDal
    {
      //  private EfAddressDal addresDal = new EfAddressDal();

        public List<CustomerDetailDto> GetAllCustomerDetail()
        {
            using (TeknikServisContext context = new TeknikServisContext())
            {
                var result =
                #region Join Sorguları

                    from customer in context.Customers
                    join CustomerGroup in context.CustomerGroups on
                        customer.CustomerGroupId equals CustomerGroup.Id
                    join address in context.Addresses on
                        customer.Id equals address.CustomerId
                    join CustomerCity in context.Cities on address.CityId equals CustomerCity.CityId
                    join CustomerDistrict in context.Districts on address.DistrictId equals CustomerDistrict.Id
                    #endregion
                    #region Select

                    select new CustomerDetailDto()
                    {
                        AddressDetail = address.Detail,
                        Phone = customer.Phone,
                        CustomerGroup = CustomerGroup.Name,
                        District = CustomerDistrict.DistrictName,
                        City = CustomerCity.Name,
                        CommercialTitle = customer.CommericalTitle,
                        Contact = customer.Contact


                    };
                #endregion
                return result.ToList();
            }

        }
       
        
        public CustomerDetailDto GeyByCustomerDetailWithId(int customerId)
        {
            using (TeknikServisContext context = new TeknikServisContext())
            {
                var result =
                #region Join Sorguları

                    from customer in context.Customers
                    where customer.Id == customerId

                    join CustomerGroup in context.CustomerGroups on
                        customer.CustomerGroupId equals CustomerGroup.Id

                    join address in context.Addresses on
                        customer.Id equals address.CustomerId
                    join CustomerCity in context.Cities on address.CityId equals CustomerCity.CityId
                    join CustomerDistrict in context.Districts on address.DistrictId equals CustomerDistrict.Id

                    #endregion
                    #region Select


                    select new CustomerDetailDto()
                    {
                        AddressDetail = address.Detail,
                        Phone = customer.Phone,
                        CustomerGroup = CustomerGroup.Name,
                        District = CustomerDistrict.DistrictName,
                        City = CustomerCity.Name,
                        CommercialTitle = customer.CommericalTitle,
                        Contact = customer.Contact
                    };
                #endregion

                return result.First();
            }

        }

    }
}
