using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;
		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}
		public void Add(Comment entity)
		{
			_commentDal.Add(entity);
		}
		public List<Comment> GetCommentsByBlogId(int blogId)
		{
			return _commentDal.GetList(comments => comments.BlogId == blogId);
		}

		public List<Comment> GetList()
		{
            throw new NotImplementedException();
        }

		public void Delete(Comment entity)
		{
			throw new NotImplementedException();
		}

		public Comment GetById(int id)
		{
			throw new NotImplementedException();
		}



		public void Update(Comment entity)
		{
			throw new NotImplementedException();
		}

	}
}
