using Infrastructure.DataAcess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
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

        [HttpGet("{id}")]
        public ActionResult Details(string id)
        {
            return View(_valuteRepository.GetValuteById(id));
        }
    }
}