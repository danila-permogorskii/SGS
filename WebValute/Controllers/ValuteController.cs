using System.Collections.Generic;
using Entities.JsonDataClasses;
using Infrastructure.DataAcess;
using Microsoft.AspNetCore.Mvc;

namespace WebValute.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ValuteController : ControllerBase
    {
        public ValuteController(IValuteRepository valuteRepository)
        {
            _valuteRepository = valuteRepository;
        }

        private IValuteRepository _valuteRepository { get; set; }

        [HttpGet]
        public IEnumerable<Valute> GetCurrencies()
        {
            return _valuteRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Valute Get(string id)
        {
            return _valuteRepository.GetValuteById(id);
        }
    }
}