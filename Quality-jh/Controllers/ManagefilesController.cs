
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace Quality_jh.Controllers
{
    public class ManagefilesController : Controller
    {
        public ActionResult MFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MFile(IFormFile File)
        {
            if (ModelState.IsValid)
            {
                if (File != null && File.Length > 0)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", File.FileName);

                    //Using Buffering
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        // The file is saved in a buffer before being processed
                        await File.CopyToAsync(stream);
                    }

                    //Using Streaming
                    //using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    //{
                    //    await SingleFile.CopyToAsync(stream);
                    //}

                    // Process the file here (e.g., save to the database, storage, etc.)
                    return RedirectToAction("Retrieve");
                }
            }

            return View("Index");
        }

        public IActionResult Retrieve()
        {

            var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
            var files = Directory.EnumerateFiles(dir).Select(fn => Path.GetFileName(fn));
            //List<string> items = new List<string>();

            //foreach (var file in files)
            //{
            //    items.Add(file);
            //}

            return View(files);
        }

        public IActionResult Views() 
        {
            return View(files);
        }
        public IActionResult Download() 
        {
            return View(files);
        }
        public IActionResult Delete() 
        {
            return View(files);
        }
    }
}

    

