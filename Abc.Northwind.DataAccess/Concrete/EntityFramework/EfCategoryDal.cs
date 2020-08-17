using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entites.Concrete;
using Abc.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
