using Microsoft.AspNetCore.Mvc;

namespace PierreOrder.Controllers

{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}