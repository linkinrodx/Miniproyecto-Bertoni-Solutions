using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Miniproyecto___Bertoni_Solutions.Conexion;
using Miniproyecto___Bertoni_Solutions.Models;
using Newtonsoft.Json;

namespace Miniproyecto___Bertoni_Solutions.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public ActionResult Index(int AlbumId = 0)
        {
            var response = Services.GetPhotos(AlbumId);
            var ListaPhotos = new List<Photo>();

            if (response != null)
            {
                ListaPhotos = JsonConvert.DeserializeObject<List<Photo>>(response);
            }

            return View(ListaPhotos);
        }
    }
}