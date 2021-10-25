using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    public class PlaceOrderController : Controller
    {
        /*    // GET: PlaceOrderController
            public ActionResult Index()
            {
                return View();
            }

            // GET: PlaceOrderController/Details/5
            public ActionResult Details()
            {
                return View();
            }*/

        // GET: PlaceOrderController/Create
        public ActionResult Create()
        {
            return View();
        }
        /*
                // POST: PlaceOrderController/Create
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

                // GET: PlaceOrderController/Edit/5
                public ActionResult Edit(int id)
                {
                    return View();
                }

                // POST: PlaceOrderController/Edit/5
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

                // GET: PlaceOrderController/Delete/5
                public ActionResult Delete(int id)
                {
                    return View();
                }

                // POST: PlaceOrderController/Delete/5
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
