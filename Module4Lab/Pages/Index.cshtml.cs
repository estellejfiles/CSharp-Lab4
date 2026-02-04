using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Lab.Pages;

public class IndexModel : PageModel
{
    // create attributes to describe the class and hold data for it
    [BindProperty]
    public string[] Shows { get; set; } = new string[3];
    public string[] SampleShows { get; set; }
    public bool ShowResults { get; set; } = false;

    // OnGet is called when page initially displayed to user
    public void OnGet()
    {
        // create new string array to hold sample shows
        SampleShows = new string[] {"A Doll's House", "Macbeth", "Sleuth"};
    } // end OnGet method

    // method called when user clicks submit button on form
    public IActionResult OnPost()
    {
        // initialize SampleShows array so we can display same ones as in OnGet
        SampleShows = new string[] {"A Doll's House", "Macbeth", "Sleuth"};

        // set ShowResults to true so values entered are displayed in GUI
        ShowResults = true;

        // return page being displayed (that is the IActionResult object)
        return Page();

    } // end OnPost method
}
