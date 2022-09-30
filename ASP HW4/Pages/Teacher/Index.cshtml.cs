using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_HW4.Data;
using ASP_HW4.Entities;

namespace ASP_HW4.Pages.Teacher
{
    public class IndexModel : PageModel
    {
        private readonly ASP_HW4.Data.TeacherContext _context;

        public IndexModel(ASP_HW4.Data.TeacherContext context)
        {
            _context = context;
        }
        
        public IList<ASP_HW4.Entities.Teacher> Teacher { get;set; }

        public async Task OnGetAsync()
        {
            if (_context.Teacher != null)
            {
                Teacher = await _context.Teacher.ToListAsync();
            }
        }
    }
}
