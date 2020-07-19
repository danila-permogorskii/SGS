using Infrastructure.DataAcess;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HtmlValuteController : Controller
    {
        public HtmlValuteController(IValuteRepository valuteRepository)
        {
            _valuteRepository = valuteRepository;
        }

        private IValuteRepository _valuteRepository { get; set; }

       

    }
}