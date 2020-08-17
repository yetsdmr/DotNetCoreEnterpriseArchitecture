using Abc.Core.DataAccess;
using Abc.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        // Store Prosedür ve join, View çağırma 
        //custom opereitn
    }
}
