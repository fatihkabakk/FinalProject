using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
