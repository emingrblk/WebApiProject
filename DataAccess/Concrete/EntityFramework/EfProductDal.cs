
using Data.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfProductDal:EfEntityRepository<Product,ProductDbContext>,IProductDal
    {
    }
}
