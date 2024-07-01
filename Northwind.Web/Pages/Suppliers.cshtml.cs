using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModel
namespace Northwind.Web.Pages;
public class SuppliersModel : PageModel 
{
    public IEnumerable<string>? Suppliers { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";
        Suppliers = [ "Alpha Co", "Beta Limited", "Gamma Corp" ];
    }
}