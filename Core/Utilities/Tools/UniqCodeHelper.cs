using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Tools
{
   public static class UniqCodeHelper
    {

        public static string GenereteUniq()
        {
            return Guid.NewGuid().ToString().Substring(0, 5).ToUpper();


        }
    }
}
