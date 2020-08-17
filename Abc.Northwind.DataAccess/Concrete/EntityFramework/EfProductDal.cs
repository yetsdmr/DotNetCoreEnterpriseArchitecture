using Abc.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.DataAccess.Abstract;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }

   
}
