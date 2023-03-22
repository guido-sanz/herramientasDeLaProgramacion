using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace clase2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> logger;

    [BindProperty] //Lo que viaja a travez de la llamada post mapeala con esta propiedad
    public Form Data {get; set;}

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametros"];
        //recibe por la url el parametro
        Data = new Form();
        Data.Mail = parametro;
        Data.Password = "1234";
    }

    public IActionResult OnPost()
    {
        if(!ModelState.IsValid){
            return Page();
        }
        var formValues = Data;
        //guardar en la db , procesar la info etc
        return RedirectToAction("get");
    }
}

