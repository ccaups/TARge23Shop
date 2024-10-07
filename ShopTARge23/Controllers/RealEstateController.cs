using Microsoft.AspNetCore.Mvc;
using ShopTARge23.Data;
using ShopTARge23.Core.ServiceInterface;

namespace ShopTARge23.Controllers
{
    public class RealEstateController : Controller
    {
        private readonly ShopTARge23Context _context;
        //private readonly IRealEstateServices _realEstateServices;

        public RealEstateController
            (
            ShopTARge23Context context
            //IRealEstateServices realEstateServices
            )
        {
            _context = context;
            //_realEstateServices = realEstateServices;

        }
        public IActionResult Index()
        {
            //var result = _context;
            return View();
        }
    }
}
