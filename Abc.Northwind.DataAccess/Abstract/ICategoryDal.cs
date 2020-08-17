using Abc.Core.DataAccess;
using Abc.Northwind.Entites.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
        // Store Prosedür ve join, View çağırma 
        //custom opereitn
    }
}
