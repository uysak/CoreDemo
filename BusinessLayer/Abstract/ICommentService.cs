using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IServiceRepository<Comment>
    {
        List<Comment> GetCommentsByBlogId(int blogId);
    }
}
