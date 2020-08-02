using bookpage.webui.Data;
using bookpage.webui.Models;
using bookpage.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace bookpage.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int? id,string q)
        {
            var products=ProductRepository.Products;
            if(id!=null)
            {
                products=products.Where(p=>p.CategoryId==id).ToList();
            }

            if(!string.IsNullOrEmpty(q))
            {
                products=products.Where(i=>i.Name.ToLower().Contains(q.ToLower())).ToList();
            }
           
            var productsViewModel = new ProductViewModel
            {
                Products = products
            };

            return View(productsViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
            //id parametresini gönderdim ve viewüzerine bir pdourct nesnesi gönderiyor
        }

        public IActionResult Read(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories=new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            if(ModelState.IsValid)//beklediğimiz tüm bilgiler uyguladığımız kurallara göre oluştu.Productta
            {
              ProductRepository.AddProduct(p);
              return RedirectToAction("list");
            }
             ViewBag.Categories=new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(p);//eğer yanlış girerse girdiği bilgilerle geldiği ekrana gitsin
           
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories=new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(ProductRepository.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
            ProductRepository.EditProduct(p);
            return RedirectToAction("list");
        }

        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");
        }
    }
}