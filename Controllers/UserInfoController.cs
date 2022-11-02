using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app1.Models;

namespace app1.Controllers;

public class UserInfoController : Controller
{
    private readonly ILogger<UserInfoController> _logger;

    public UserInfoController(ILogger<UserInfoController> logger)
    {
        _logger = logger;
    }

    public IActionResult UserInfo1()
    {
        return View();
    }

    public IActionResult UserInfo2()
    {
        return View();
    }

    public IActionResult UserInfo3()
    {
        return View();
    }

    public IActionResult UserInfo4()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
