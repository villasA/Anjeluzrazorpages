#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Anjeluzrazorpages.Data;

namespace Anjeluzrazorpages.Pages.fashion
{
    public class IndexModel : PageModel
    {
        private readonly Anjeluzrazorpages.Data.AnjeluzrazorpagesContext _context;

        public IndexModel(Anjeluzrazorpages.Data.AnjeluzrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
