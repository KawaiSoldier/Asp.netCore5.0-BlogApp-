using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment{ID=1,Username="Yusuf"},
				new UserComment{ID=2,Username="Ali"},
				new UserComment{ID=3,Username="Veli"},
				new UserComment{ID=4,Username="Ayşe"},
				new UserComment{ID=5,Username="Fatma"}
			};
			return View(commentvalues);
		} 
	}
}
