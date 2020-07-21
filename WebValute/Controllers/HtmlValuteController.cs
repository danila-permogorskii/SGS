using Infrastructure.DataAcess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebValute.Controllers
{
    [Route("html/[controller]")]
    public class HtmlValuteController : Controller
    {
        public HtmlValuteController(IValuteRepository valuteRepository)
        {
            _valuteRepository = valuteRepository;
        }

        private IValuteRepository _valuteRepository { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_valuteRepository.GetAll());
        }
    }
}