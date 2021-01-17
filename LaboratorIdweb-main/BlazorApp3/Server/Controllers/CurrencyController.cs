using BlazorApp3.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        [HttpGet]
        public CurrencyList GetCurrencies()
        {
            return new CurrencyList
            {
                Currencies = CurrencyManager.Currencies
            };
        }
    }
}
