using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Concrete
{
    public class ServiceType:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
