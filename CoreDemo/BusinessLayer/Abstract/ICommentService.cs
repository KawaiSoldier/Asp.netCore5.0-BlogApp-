using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		List<Comment> GetList(int id);
		void CommentAdd(Comment coment);

		//Comment GetById(int id);
		//void CommentUpdate(Comment comment);
		//void CommentDelete(Comment comment);
	}
}
