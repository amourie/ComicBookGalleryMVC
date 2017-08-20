using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGalleryMVC.Controllers
{
    public class ComicBooksController : Controller //inherits from base Controller class
    {
        public string Index()
        {
            return "this is the comic books default method";
        }
        public string Detail()
        {
            return "hello from comic books detail method";
        }

    }
}