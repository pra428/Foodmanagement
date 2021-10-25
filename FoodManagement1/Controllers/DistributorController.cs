using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    public class DistributorController : Controller
    {
        // GET: DistributorController
        /* public ActionResult Index()
         {
             return View();
         }

         // GET: DistributorController/Details/5
         public ActionResult Details()
         {
             return View();
         }

         // GET: DistributorController/Create*/
        public ActionResult Create()
        {
            return View();
        }

        /* // POST: DistributorController/Create
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Create(IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: DistributorController/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: DistributorController/Edit/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Edit(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }

         // GET: DistributorController/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: DistributorController/Delete/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Delete(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }*/
    }
}
