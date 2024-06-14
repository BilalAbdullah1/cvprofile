using imageUploading.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace imageUploading.Controllers
{
    public class HomeController : Controller
    {

        static Gallery g = new Gallery();


        [HttpGet]
        public IActionResult Index()
        {
            var model = new Gallery();
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(Gallery gal, IFormFile img)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(gal);
            //}

            if (img != null && img.Length > 0)
            {
                var fileName = Path.GetFileName(img.FileName);
                string imgFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/myfiles");

                if (!Directory.Exists(imgFolder))
                {
                    Directory.CreateDirectory(imgFolder);
                }

                string filePath = Path.Combine(imgFolder, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                string uploadPath = Path.Combine("myfiles", fileName);
                gal.image = uploadPath;
            }

            List<string> selectedSkills = new List<string>();
            //SKILLS

            if (gal.HTML) selectedSkills.Add("HTML");
            if (gal.CSS) selectedSkills.Add("CSS");
            if (gal.JavaScript) selectedSkills.Add("JavaScript");
            if (gal.Python) selectedSkills.Add("Python");
            if (gal.React) selectedSkills.Add("React");
            if (gal.Nodejs) selectedSkills.Add("Node.js");
            if (gal.Angular) selectedSkills.Add("Angular");
            if (gal.Java) selectedSkills.Add("Java");
            if (gal.Csharp) selectedSkills.Add("C#");

            List<string> selectedHobbies = new List<string>();
            //HOBIES
            if (gal.Reading) selectedHobbies.Add("Reading");
            if (gal.Sports) selectedHobbies.Add("Sports");
            if (gal.Music) selectedHobbies.Add("Music");
            if (gal.Travel) selectedHobbies.Add("Travel");
            if (gal.Cooking) selectedHobbies.Add("Cooking");
            if (gal.Gaming) selectedHobbies.Add("Gaming");
            if (gal.Photography) selectedHobbies.Add("Photography");
            if (gal.Painting) selectedHobbies.Add("Painting");

            ViewBag.SelectedSkills = selectedSkills;
            ViewBag.SelectedHobbies = selectedHobbies;

            return View("Gallery", gal); 
        }

        public IActionResult Gallery()
        {
            return View(g);
        }

    }
}