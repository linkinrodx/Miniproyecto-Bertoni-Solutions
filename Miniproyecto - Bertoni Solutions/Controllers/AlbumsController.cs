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
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            var response = Services.GetAlbums();
            var ListaAlbums = new List<Album>();

            if (response != null)
            {
                ListaAlbums = JsonConvert.DeserializeObject<List<Album>>(response);
            }

            return View(ListaAlbums);
        }
    }
}