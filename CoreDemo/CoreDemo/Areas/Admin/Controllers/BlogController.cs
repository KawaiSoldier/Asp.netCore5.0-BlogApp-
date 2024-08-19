using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using BusinessLayer.Concrete;


namespace App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult ExportStaticExelBlogList()  // ileride Yazarlar ile listeleme yapılacak
        {
            using (var WorkBook = new XLWorkbook())
            { 
            
                var WorkSheet = WorkBook.Worksheets.Add("Blogs");
                WorkSheet.Cell(1 , 1).Value = "Blog ID";
                WorkSheet.Cell(1 , 2).Value = "Title";              
                WorkSheet.Cell(1 , 3).Value = "Date";
                WorkSheet.Cell(1 , 4).Value = "Category";
                //WorkSheet.Cell(1 , 5).Value = "Writer";


                int BlogRawCount = 2;

                foreach (var item in bm.GetBlogListWithCategory())
                {
                    WorkSheet.Cell(BlogRawCount ,1).Value = item.BlogID;
                    WorkSheet.Cell(BlogRawCount, 2).Value = item.BlogTitle;
                    WorkSheet.Cell(BlogRawCount, 3).Value = item.BlogCrateDate;
                    WorkSheet.Cell(BlogRawCount, 4).Value = item.Category.CategoryName;
                    //WorkSheet.Cell(BlogRawCount, 5).Value = item.Writer.WriterName;

                    BlogRawCount++;
                }
                using (var stream = new System.IO.MemoryStream())
                    {
                    WorkBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogList.xlsx");
                }

            }
              
        }

      
    }
}
