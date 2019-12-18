using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.Services;
using AspNetCoreVideo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    
    public class HomeController : Controller
    {

        private IVideoData _videos;
        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index ()
        //{
        //    return "Hello,from the controller!";
        //}

        //public ObjectResult Index()
        //{
        //    var model = new Video { Id = 1, Title = "Shreck" };
        //    return new ObjectResult(model);
        //}

        
        public ViewResult Index()
        {
            //var model = new List<Video>
            //{
            //    new Video{Id =1,Title = "Shreck" },
            //    new Video{Id =2,Title = "Despicable Me" },
            //    new Video{Id = 3,Title = "Megamind" }
            //};
            //return View(model);

            //var model = _videos.GetAll();

            //return View(model);

            var model = _videos.GetAll().Select(video => new VideoViewModel
            {
                Id = video.Id,
                Title = video.Title,
                Genre = video.Genre
            });
            return View(model);
        }


        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);

            //  return new ObjectResult(model);


            if (model == null) return RedirectToAction("Index");
            return View(new VideoViewModel
            {
                Id = model.Id,
                Title = model.Title,
                // Genre = Enum.GetName(typeof(Genres), model.Genre)
                Genre = model.Genre
            });
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(VideoViewModel model)
        {
            if(ModelState.IsValid)
            {
                var video = new Video
                {
                    Title = model.Title,
                    Genre = model.Genre
                };
                _videos.Add(video);

                return RedirectToAction("Details", new { id = video.Id });

            }

            return View();
           
        }





    }
}