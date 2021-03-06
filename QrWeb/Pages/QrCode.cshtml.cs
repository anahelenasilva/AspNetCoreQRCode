using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QrWeb.Pages
{
    public class QrCodeModel : PageModel
    {
        public IActionResult OnGet([FromQuery] string url)
        {
            var image = QrCodeGenerator.GenerateByteArray(url);
            return File(image, "image/png");
        }
    }
}