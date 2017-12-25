using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using MusicStore.Infrastructure;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly MusicStoreEntities _storeContext = new MusicStoreEntities();

        public HomeController(ILogger logger)
        {
            _logger = logger;
            _logger.Info("HomeController created");
        }

        // GET: /Home/
        public async Task<ActionResult> Index()
        {
            _logger.Trace("Homecontroller Index method started");
            var resultView = View(await _storeContext.Albums
                .OrderByDescending(a => a.OrderDetails.Count)
                .Take(6)
                .ToListAsync());
            _logger.Trace("Homecontroller Index method finished");
            return resultView;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _storeContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}