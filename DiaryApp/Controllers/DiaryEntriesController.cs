using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {

        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {

            // Server side validation
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title","Title must be between 3 to 100 characters");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj); // Add data into table
                _db.SaveChanges();// to save changes in db
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public IActionResult Edit(int? id)
        {

            if(id==null || id<=0)
            {
                return NotFound();
            }

            DiaryEntry? diaryentry = _db.DiaryEntries.Find(id);

            if(diaryentry==null)
            {
                return NotFound();
            }

            return View(diaryentry);
        }


        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {

            // Server side validation
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title must be between 3 to 100 characters");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj); // Update data into table
                _db.SaveChanges();// to save changes in db
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {

            if (id == null || id <= 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryentry = _db.DiaryEntries.Find(id);

            if (diaryentry == null)
            {
                return NotFound();
            }

            return View(diaryentry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            
            _db.DiaryEntries.Remove(obj); // Delete data into table
            _db.SaveChanges();// to save changes in db
            return RedirectToAction("Index");
        }
    }
}
