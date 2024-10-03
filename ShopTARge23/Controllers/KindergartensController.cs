using Microsoft.AspNetCore.Mvc;
using ShopTARge23.Core.ServiceInterface;
using ShopTARge23.Data;
using ShopTARge23.Models.Kindergartens;
using ShopTARge23.Models.Spaceships;

namespace ShopTARge23.Controllers
{
    public class KindergartensController : Controller
    {
        private readonly ShopTARge23Context _context;
        private readonly IKindergartensServices _kindergartensServices;

        public KindergartensController
            (
                ShopTARge23Context context,
                IKindergartensServices kindergartensServices
            )
        {
            _context = context;
            _kindergartensServices = kindergartensServices;
        }

        public IActionResult Index()
        {
            var result = _context.Kindergartens
                .Select(x => new KindergartensIndexViewModel
                {
                    Id = x.Id,
                    GroupName = x.GroupName,
                    ChildrenCount = x.ChildrenCount,
                    KindergartenName = x.KindergartenName,
                    Teacher = x.Teacher
                });

            return View(result);
        }
    }
}
