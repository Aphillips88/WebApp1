
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp1.Pages
{
    [Authorize]
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

//above code was changed to test denying anonymous access to the home pages.

///*****without testing identity use below code

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Extensions.Logging;

///namespace WebApp1.Pages;

//public class PrivacyModel : PageModel
//{
   // private readonly ILogger<PrivacyModel> _logger;

    //public PrivacyModel(ILogger<PrivacyModel> logger)
    //{
       // _logger = logger;
    //}

    //public void OnGet()
    //{
   // }
//}