using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace Things.Controllers
{
  public class StuffController : Controller
  {

    // [HttpGet("/things")]
    // public ActionResult Index()
    // {
      // Stuff newStuff = new Stuff("hello", 2, 3);
    //   List<Stuff> allItems = Stuff.GetAll();
    //   return View(allItems);
    // }

    [HttpGet("/things/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/things")]
    public ActionResult Create(string items, int packed, int amount)
    {
      // Stuff myItems = new Stuff(items, packed, amount);
      return RedirectToAction("Index");
    }
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Places.ClearAll();
    //   return View();
    // }
    //
    [HttpGet("/things/{id}")]
    public ActionResult Show(int id)
    {
      Stuff items = Stuff.Find(id);
      return View(items);
    }
  }
}
