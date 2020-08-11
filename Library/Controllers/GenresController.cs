using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Library.Models;

namespace Library.Controllers
{
  [Authorize]
  public class GenresController : Controller
  {
    private readonly LibraryContext _db;

    public GenresController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Genres.OrderBy(genre => genre.Name).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Genre genre)
    {
      _db.Genres.Add(genre);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisGenre = _db.Genres
          .Include(genre => genre.Books)
          .ThenInclude(join => join.Book)
          .FirstOrDefault(genre => genre.GenreId == id);
      return View(thisGenre);
    }

    public ActionResult Edit(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(genres => genres.GenreId == id);
      return View(thisGenre);
    }

    [HttpPost]
    public ActionResult Edit(Genre genre)
    {
      _db.Entry(genre).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(genres => genres.GenreId == id);
      return View(thisGenre);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisGenre = _db.Genres.FirstOrDefault(genres => genres.GenreId == id);
      _db.Genres.Remove(thisGenre);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}