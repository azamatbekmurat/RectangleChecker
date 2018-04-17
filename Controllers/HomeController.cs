using System;
using Microsoft.AspNetCore.Mvc;
using RectangleChecker.Models;

namespace RectangleChecker.Controllers
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
