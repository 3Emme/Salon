using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController: Controller
  {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
        _db = db;
    }
    public ActionResult Create(int id)
      {
        ViewBag.StylistId = id;
        return View();
      }
      [HttpPost]
      public ActionResult Create(Client client )
      {
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Create");
      }
  }
}