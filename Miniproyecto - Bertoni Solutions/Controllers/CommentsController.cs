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
    public class CommentsController : Controller
    {
        // GET: Comments
        public ActionResult Index(int PhotoId = 0)
        {
            var response = Services.GetComments(PhotoId);
            var ListaComments = new List<Comment>();

            if (response != null)
            {
                ListaComments = JsonConvert.DeserializeObject<List<Comment>>(response);
            }

            return View(ListaComments);
        }
    }
}