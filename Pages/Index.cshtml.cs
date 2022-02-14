using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SupposedlySecureApplication.Services;

namespace SupposedlySecureApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IOptions<Secrets> _secrets;

        public IndexModel(
            ILogger<IndexModel> logger,
            IOptions<Secrets> secrets
            )
        {
            _logger = logger;
            _secrets = secrets;
        }

        public void OnGet()
        {
        }
    }
}