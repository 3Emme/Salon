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
      return RedirectToAction("Index","Home");
    }
    public ActionResult Details(int id)
    {
      Client model =  _db.Clients.FirstOrDefault(x => x.ClientId == id);
      return View(model);
    }
    public ActionResult Edit(int id)
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      var thisClient = _db.Clients.FirstOrDefault(x => x.ClientId == id);
      return View(thisClient);
    }
    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Edit");
    }
    public ActionResult Delete(int id)
    {
      Client client = _db.Clients.FirstOrDefault(x => x.ClientId == id);
      _db.Clients.Remove(client);
      _db.SaveChanges();
      return RedirectToAction("Index","Home");  
    }
  }
}