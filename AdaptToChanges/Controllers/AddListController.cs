using AdaptToChanges.Data;
using AdaptToChanges.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AdaptToChanges.Controllers
{
    public class AddListController : Controller
    {
        private readonly AdaptToChangesDbContext _context;
        private const string List = "ToDoLists";

        public AddListController(AdaptToChangesDbContext context)
        {
            _context = context;
        }

        public IActionResult Add(int id)
        {
            ToDoList? listToAdd = _context.ToDoLists.Where(l => l.ToDoListId == id).SingleOrDefault();

            if (listToAdd == null)
            {
                TempData["Message"] = "Sorry! That list no longer exists.";
                return RedirectToAction("Index", "ToDoLists");
            }

            ListViewModel listView = new()
            {
                ToDoListId = listToAdd.ToDoListId,
                ToDoListName = listToAdd.ToDoListName,
                ToDoListDescription = listToAdd.ToDoListDescription,
                /*MemberId = listToAdd.MemberId,
                MemberName = listToAdd.MemberName*/
            };

            List<ListViewModel> listViews = GetExistingListData();
            listViews.Add(listView);
            WriteListCookie(listViews);

            TempData["Message"] = "List was added";
            return RedirectToAction("Index", "ToDoLists");
        }

        private void WriteListCookie(List<ListViewModel> listView)
        {
            string cookieData = JsonConvert.SerializeObject(listView);

            HttpContext.Response.Cookies.Append(List, cookieData, new CookieOptions()
            {
                Expires = DateTimeOffset.Now.AddYears(1)
            });
        }

        private List<ListViewModel> GetExistingListData()
        {
            string? cookie = HttpContext.Request.Cookies[List];
            if (string.IsNullOrWhiteSpace(cookie))
            {
                return new List<ListViewModel>();
            }

            return JsonConvert.DeserializeObject<List<ListViewModel>>(cookie);
        }

        public IActionResult ListSummary()
        {
            List<ListViewModel> listViews = GetExistingListData();
            return View(listViews);
        }

        public IActionResult Remove(int id)
        {
            List<ListViewModel> listViews = GetExistingListData();

            ListViewModel? targetList =
                listViews.Where(listViews => listViews.ToDoListId == id).FirstOrDefault();

            listViews.Remove(targetList);

            WriteListCookie(listViews);

            return RedirectToAction(nameof(ListSummary));
        }
    }
}