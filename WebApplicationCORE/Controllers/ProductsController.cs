using APP.Business.Models;
using APP.DataAccess;
using CORE.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCORE.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Service<Product, ProductRequest, ProductResponse> _service;

        public ProductsController(Service<Product, ProductRequest, ProductResponse> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.GetList();
            
            // Way 1:
            //ViewData["RecordsCount"] = result.Message;
            // Way 2:
            ViewBag.RecordsCount = result.Message;
            return View(result.Data);
        }
        public IActionResult Details(int id)
        {
            var result = _service.GetItem(id);
            ViewBag.Message = result.Message;
            return View(result.Data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var result = _service.Create(request);
            if (!result.IsSuccessful)
            {
                ViewBag.Message = result.Message;
                return View(request);
            }
            TempData["OperationMessage"] = result.Message;
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var result = _service.GetItemForEdit(id);
            ViewBag.Message = result.Message;
            return View(result.Data);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(ProductRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var result = _service.Update(request);
            if (!result.IsSuccessful)
            {
                ModelState.AddModelError("", result.Message);
                return View(request);
            }
            TempData["OperationMessage"] = result.Message;
            return RedirectToAction(nameof(Index));
        }


    }
}
