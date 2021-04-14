using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
  public class BusinessRules
    {
        public static IDataResult<List<IResult>> Run(params IResult[] logics)
        {
            List<IResult> ErrorResult = new List<IResult>();
            List<IResult> SuccessResult = new List<IResult>() { new SuccessResult() };

            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    ErrorResult.Add(logic);
                }
            
            }

            if (ErrorResult.Count<=0)
            {
                return new SuccessDataResult<List<IResult>>(SuccessResult);

            }
            return new ErrorDataResult<List<IResult>>(ErrorResult);
        }
    }
}
