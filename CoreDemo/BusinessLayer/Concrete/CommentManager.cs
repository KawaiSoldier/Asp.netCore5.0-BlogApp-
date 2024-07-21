using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
		public void CommentAdd(Comment coment)
		{
			_commentDal.Insert(coment);
		}

		public List<Comment> GetList(int id)
		{
		return	_commentDal.GetListAll(x=> x.BlogID == id);
		}
	}
}
