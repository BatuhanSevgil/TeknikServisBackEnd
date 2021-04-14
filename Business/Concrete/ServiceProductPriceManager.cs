using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using Business.Constants;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ServiceProductPriceManager : IServiceProductPriceService
    {

        IServiceProductPriceDal _priceDal;

        public ServiceProductPriceManager(IServiceProductPriceDal priceDal)
        {

            _priceDal = priceDal;
        }

        public IDataResult<List<IResult>> Add(ServiceProductPrice productPrice)
        {
            var result = BusinessRules.Run(


                ToplamFiyatIsNull(productPrice),
                ToplamFiyatIsCorrect(productPrice),
                ToplamFiyatIsNegative(productPrice)



                ) ;
            


            if (result.Success)
            {
                _priceDal.Add(productPrice);
                return new SuccessDataResult<List<IResult>>(result.Data);
            }
            return new ErrorDataResult<List<IResult>>(result.Data);
        }

        public IResult Update(ServiceProductPrice productPrice)
        {
            _priceDal.Update(productPrice);
            return new SuccessResult();
        }


        //Price Rules 

        private IResult ToplamFiyatIsNull(ServiceProductPrice productPrice) {

            if (productPrice.ToplamFiyat == 0)
            {
                productPrice.ToplamFiyat = (productPrice.Nakliye + productPrice.Parca + productPrice.Iscilik+productPrice.ArizaTespit) - productPrice.Iskonto;
            
            }
            return new SuccessResult();

        }

        private IResult ToplamFiyatIsCorrect(ServiceProductPrice productPrice) {

            decimal expectedToplamFiyat = (productPrice.ArizaTespit + productPrice.Iscilik + productPrice.Nakliye + productPrice.Parca) - productPrice.Iskonto;

            if (expectedToplamFiyat!=productPrice.ToplamFiyat)
            {
                return new ErrorResult(BusinessMessages.ToplamFiyatIsNotCorrect);

            }


            return new SuccessResult();
        }

        private IResult ToplamFiyatIsNegative(ServiceProductPrice productPrice)
        {
            if (productPrice.ToplamFiyat<0)
            {
                return new ErrorResult(BusinessMessages.ToplamFiyatUnderZero);

            }
            return new SuccessResult();
        }
    }
}
