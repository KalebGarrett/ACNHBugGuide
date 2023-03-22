using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ACNHBugGuide.Web.Models;
using ACNHBugGuide.Web.Services;

namespace ACNHBugGuide.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BugService _bugService;

    public HomeController(ILogger<HomeController> logger, BugService bugService)
    {
        _logger = logger;
        _bugService = bugService;
    }

    public async Task<IActionResult> Index()
    {
        var model = new IndexViewModel();
        model.Bugs = await _bugService.GetAll();
        return View(model);
    }

    [HttpGet("bug/{fileName}")]
    public async Task<IActionResult> Bug(string fileName)
    {
        var model = new BugViewModel();
        model.Bug = await _bugService.Get(fileName);
        if (model.Bug == null)
        {
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [HttpGet("search")]
    [HttpPost("search")]
    public async Task<IActionResult> SearchResults(string query)
    {
        var model = new SearchViewModel();
        model.Query = query;
        model.Results = await _bugService.Search(query);
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}