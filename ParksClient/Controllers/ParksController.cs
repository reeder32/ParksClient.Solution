using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ParksClient.Models;
using System;
using Newtonsoft.Json;
namespace ParksClient.Controllers
{
  public class ParksController : Controller
  {
    public IActionResult Index(string name, string state, string city, string type, string zipcode, string radius)
    {
      var parks = Park.GetParks(name, state, city, type, zipcode, radius);
      return View(parks);
    }
     public IActionResult Details(int id)
    {
      var park = Park.GetWithId(id);
      return View(park);
    }
    public IActionResult Create() => View();
    
    [HttpPost]
    public IActionResult Create(Park park)
    {
      Console.WriteLine($"park: {park.Name}");
      Park.Post(park);
      return RedirectToAction("Index");
    }
     public async Task<ActionResult> Delete(int id)
     {
      var jsonPark = await ApiHelper.GetWithId(id);
      var foundPark = JsonConvert.DeserializeObject<Park>(jsonPark);
      return View(foundPark);
    }
    
   [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
      Park.Delete(id);
      return RedirectToAction("Index");
      }

  }
}