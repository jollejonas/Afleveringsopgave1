using Microsoft.AspNetCore.Mvc;
using Afleveringsopgave.Models;

namespace Afleveringsopgave.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult AddForm()
    {
        return View();
    }

    [HttpPost] 
    public ViewResult AddForm(ShoppingList shoppingList)
    {
        if (ModelState.IsValid)
        {
            Repository.AddToShoppingList(shoppingList);
            return View("ItemAdded", shoppingList);
        }
        else
        {
            return View();
        }
    }

    [HttpGet]
    public ViewResult ListItems()
    {
        return View(Repository.ShoppingListItems);
    }

    [HttpPost]
    public IActionResult RemoveItems(int itemId)
    {
        Repository.RemoveItem(itemId);
        return RedirectToAction("ListItems");
    }
}
