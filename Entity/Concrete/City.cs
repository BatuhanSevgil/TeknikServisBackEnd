using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public  class City:IEntity
    {
        public int CityId  { get; set; }
        public string Name { get; set; }
    }
}
