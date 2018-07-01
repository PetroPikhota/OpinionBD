using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OpinionDB.Models;

namespace OpinionDB.Pages
{
    public class ShowOpinionModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Opinion> opinions { get; set; }
        public ShowOpinionModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            opinions = _context.Opinion.AsNoTracking().ToList();
        }
    }
}