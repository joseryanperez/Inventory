using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreMvcFull.Controllers
{
  public class InventoriesController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
