using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace final_vjwill77.Pages;

public class Register25KModel : PageModel
{
    private readonly ILogger<Register25KModel> _logger;
    [BindProperty]
    [Display(Name = "First Name")]
    public string FirstName {get; set;} = string.Empty;

    [BindProperty]
    [Display(Name = "Last Name")]
    public string LastName {get; set;} = string.Empty;

    [BindProperty]
    [Display(Name = "Shirt Size")]
    public int ShirtSize {get; set;}

    [BindProperty]
    public string Gender {get; set;} = string.Empty;

    [BindProperty]
    [EmailAddress]
    public string Email {get; set;} = string.Empty;

    [BindProperty]
    public int Age {get; set;}

    public Register25KModel(ILogger<Register25KModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        _logger.LogWarning($"OnPost() called. Name = {FirstName} {LastName} Shirt Size = {ShirtSize} Gender = {Gender} Email = {Email} Age = {Age}");
    }
}
