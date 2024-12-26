using ASP_Net_Core_MVC.Data;
using ASP_Net_Core_MVC.Models;
using ASP_Net_Core_MVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_Net_Core_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public StudentController(ApplicationDBContext dbContext) 
        {
        
           this._dbContext = dbContext;
        
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(StudentModel  model)
        {
            var student = new Student
            {
                Name = model.Name,
                Description = model.Description,
                EmailId = model.EmailId,    
                Subcrived = model.Subcrived,    
            };

               await _dbContext.Student.AddAsync(student); 
                await _dbContext.SaveChangesAsync();

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> List()
        {
            var Data= await _dbContext.Student.ToListAsync();
            return View(Data);
        }
    }
}
