using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class CKEditorController : Controller
    {
        // GET: CKEditor
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult UploadImage(HttpPostedFileBase upload)
        //{
        //    if (upload != null && upload.ContentLength > 0)
        //    {
        //        var fileName = Path.GetFileName(upload.FileName);
        //        var path = Path.Combine(Server.MapPath("~/Content/uploads/Images/"), fileName);
        //        upload.SaveAs(path);
        //        return Json(new { uploaded = true, url = Url.Content("~/Content/uploads/Images/" + fileName) });
        //    }
        //    return Json(new { uploaded = false, error = new { message = "No file uploaded." } });
        //}
        //[HttpPost]
        //public ActionResult UploadImage1(HttpPostedFileBase file)
        //{
        //    if (file != null && file.ContentLength > 0)
        //    {
        //        // Save the uploaded image to the server
        //        string fileName = Path.GetFileName(file.FileName);
        //        string filePath = Path.Combine(Server.MapPath("~/Content/uploads/Images/"), fileName);
        //        file.SaveAs(filePath);

        //        // Return the URL of the uploaded image
        //        string imageUrl = Url.Content("~/Content/uploads/Images/" + fileName);
        //        return Content(imageUrl);
        //    }

        //    // Handle error case
        //    return Content("");
        //}
    }
}