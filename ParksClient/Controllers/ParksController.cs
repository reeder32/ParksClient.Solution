using Microsoft.AspNetCore.Mvc;
using ParksClient.Models;

namespace ParksClient.Controllers
{
  public class ParksController : Controller
  {
    public IActionResult Index()
    {
      var parks = Park.GetParks();
      return View(parks);
    }
     public IActionResult Details(int id)
    {
      var park = Park.GetWithId(id);
      return View(park);
    }
  }
}