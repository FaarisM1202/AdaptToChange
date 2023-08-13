using AdaptToChanges.Data;
using AdaptToChanges.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdaptToChanges.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly AdaptToChangesDbContext _context;
        public ToDoListController(AdaptToChangesDbContext context)
        {
            _context = context;
        }

       public async Task<IActionResult> Index(int? id)
       {


            List<ToDoList> toDoLists = await (from ToDoList in _context.ToDoLists
                                              select ToDoList).ToListAsync();


            ToDoListViewModel listModel = new(toDoLists);
            return View(listModel);
       }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ToDoList toDoList)
        {
            if(ModelState.IsValid)
            {
                _context.ToDoLists.Add(toDoList);
                await _context.SaveChangesAsync();

                ViewData["Message"] = $"{toDoList.ToDoListName} was created successfully!";
                return View();
            }
            return View(toDoList);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ToDoList? listToEdit = await _context.ToDoLists.FindAsync(id);

            if(listToEdit == null) 
            {
                return NotFound();
            }

            return View(listToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ToDoList toDoListModel)
        {
            if(ModelState.IsValid) 
            {
                _context.ToDoLists.Update(toDoListModel);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{toDoListModel.ToDoListName} was updated successfully!";
                return RedirectToAction("Index");
            }
            
            return View(toDoListModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            ToDoList? listToDelete = await _context.ToDoLists.FindAsync(id);

            if(listToDelete == null)
            {
                return NotFound();
            }

            return View(listToDelete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ToDoList? listToDelete = await _context.ToDoLists.FindAsync(id);

            if(listToDelete != null)
            {
                _context.ToDoLists.Remove(listToDelete);
                await _context.SaveChangesAsync();
                TempData["Message"] = $"{listToDelete.ToDoListName} was deleted successfully!";
                return RedirectToAction("Index");
            }

            TempData["Message"] = "This list was already deleted!";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            ToDoList? listToDescription = await _context.ToDoLists.FindAsync(id);

            if(listToDescription == null)
            {
                return NotFound();
            }

            return View(listToDescription);
        }
    }
}
