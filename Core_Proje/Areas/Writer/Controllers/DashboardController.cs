using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname; // Dashboard kullanıcı karşılama ismini çeken vbag.

            //WEATHER API
            string api = "7d2fff2ff7ba295120ab55c9cf720e22";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=sakarya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //Statistics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x=>x.Receiver == values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();

            return View();
        }
    }
}

/* API = https://api.openweathermap.org/data/2.5/weather?q=sakarya&mode=xml&lang=tr&units=metric&appid=7d2fff2ff7ba295120ab55c9cf720e22/ */
