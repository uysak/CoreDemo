using DataAccessLayer.Abstract;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository : EfRepositoryBase<Writer>, IWriterDal
    {
    }
}
