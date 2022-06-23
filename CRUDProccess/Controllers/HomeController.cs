using CRUDProccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDProccess.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context ; 


        public HomeController(ILogger<HomeController> logger,Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Students.ToList();
            return View(list);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var student =await _context.Students.FindAsync(Id);
            _context.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Create(Student student)
        {
            await _context.AddAsync(student);//girilen parametreyi student olarak alıyorum 
            await _context.SaveChangesAsync();//aldığım parametreyi kaydediyorum
            return RedirectToAction(nameof(Index));//kaydettikten sonra index sayfasına geri gönderiyoruz.
        }



        public IActionResult Student(int? Id)
        {
            Student student;
            if (Id.HasValue)
            {
                student = _context.Students.Find(Id);
            }
            else
            {
                student = new Student();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
