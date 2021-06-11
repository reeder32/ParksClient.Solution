using Microsoft.AspNetCore.Mvc;
using ParksClient.Models;
using System;
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
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create(Park park)
    {
      Console.WriteLine($"park: {park.Name}");
      Park.Post(park);
      return RedirectToAction("Index");
    }

  }
}