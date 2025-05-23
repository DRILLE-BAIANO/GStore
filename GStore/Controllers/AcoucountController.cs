
using GStore.Models;
using GStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace GStore.Data;

public class AcoucountController : Controller
{
    private readonly ILogger<AcoucountController> _logger;
    private readonly SignInManager<Usuario> _singnInManager;
    private readonly UserManager<Usuario> _userManager;
    private readonly IWebHostEnvironment _host;


    public AcoucountController(
        ILogger<AcoucountController> logger,
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        IWebHostEnvironment host 
    )
    {
        _logger = logger;
        _singnInManager = signInManager;
        _userManager = userManager;
        _host = host;
    }


    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }
}