﻿using AdaptToChanges.Data;
using AdaptToChanges.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AdaptToChange.Controllers
{
    public class AddListController : Controller
    {
        private readonly AdaptToChangesDbContext _context;
        private const string List = "List";
        public IActionResult Add(int id)
        {
            ToDoList listToAdd = _context.ToDoLists.Where(l => l.ToDoListId == id).SingleOrDefault();

            if (listToAdd == null)
            {
                TempData["Message"] = "Sorry! That list no longer exists.";
            }

            ToDoList listView = new()
            {
                ToDoListId = listToAdd.ToDoListId,
                ToDoListName = listToAdd.ToDoListName,
                ToDoListDescription = listToAdd.ToDoListDescription,
                MemberId = listToAdd.MemberId,
                MemberName = listToAdd.MemberName
            };

            List<ToDoList> listViews = GetExistingListData();
            listViews.Add(listView);
            WriteListCookie(listViews);

            TempData["Message"] = "List was added";
            return RedirectToAction("Index", "ListAdd");
        }

        private void WriteListCookie(List<ToDoList> listView)
        {
            string cookieData = JsonConvert.SerializeObject(listView);

            HttpContext.Response.Cookies.Append(List, cookieData, new CookieOptions()
            {
                Expires = DateTimeOffset.Now.AddYears(1)
            });
        }

        private List<ToDoList> GetExistingListData()
        {
            string? cookie = HttpContext.Request.Cookies[List];
            if (string.IsNullOrWhiteSpace(cookie))
            {
                return new List<ToDoList>();
            }

            return JsonConvert.DeserializeObject<List<ToDoList>>(cookie);
        }

        public IActionResult ListSummary()
        {
            List<ToDoList> listViews = GetExistingListData();
            return View(listViews);
        }

        public IActionResult Remove(int id)
        {
            List<ToDoList> listViews = GetExistingListData();

            ToDoList? targetList =
                listViews.Where(listViews => listViews.ToDoListId == id).FirstOrDefault();

            listViews.Remove(targetList);

            WriteListCookie(listViews);

            return RedirectToAction("Index");
        }
    }
}