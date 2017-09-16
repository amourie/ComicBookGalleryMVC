using ComicBookGalleryMVC.Data;
using ComicBookGalleryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {


        private ComicBookRepository _comicBookRepository = null;


        //Constructor method
        public ComicBooksController() {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            else
            {
                var comicBook = _comicBookRepository.GetComicBook((int)id);

                    return View(comicBook);
                }
            

        }
    }
}