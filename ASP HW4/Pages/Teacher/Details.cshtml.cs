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
    public class DetailsModel : PageModel
    {
        private readonly ASP_HW4.Data.TeacherContext _context;

        public DetailsModel(ASP_HW4.Data.TeacherContext context)
        {
            _context = context;
        }

      public ASP_HW4.Entities.Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }
            else 
            {
                Teacher = teacher;
            }
            return Page();
        }
    }
}
