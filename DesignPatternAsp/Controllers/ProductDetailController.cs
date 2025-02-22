using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private LocalEarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            IEarn localEarn = _localEarnFactory.GetEarn();
            IEarn foreignEarn = _foreignEarnFactory.GetEarn();

            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);
            return View();
        }
    }
}
