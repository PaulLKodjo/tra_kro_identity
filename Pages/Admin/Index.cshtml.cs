using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tra_kro_identity_.Pages.Admin;

[SecurityHeaders]
[Authorize]
public class IndexModel : PageModel
{
    public void OnGet()
    {

    }
}