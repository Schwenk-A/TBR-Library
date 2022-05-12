using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TBR.Webb.Models
{
    public class IndexModel : PageModel
    {
        //public async Task OnGetAsync()
        //{
        //    var accessToken = await HttpContext.GetTokenAsync(
        //        GoogleDefaults.AuthenticationScheme, "access_token");

        //    // ...
        //}

        
         public async Task<IActionResult> OnPostLogoutAsync()
        {
            // using Microsoft.AspNetCore.Authentication;
            await HttpContext.SignOutAsync();
            return RedirectToPage();
        }
    }


}

