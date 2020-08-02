using System.Collections.Generic;
using bookpage.webui.Data;
using bookpage.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace bookpage.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent//heryerde category var zaten o yüzden sürekli indexten almayayım diye bağımsız bir yapı oluşturuyorum
    {
        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString()=="List")
           ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(CategoryRepository.Categories);//buradaki yapımı silip bunu yazdım artık cateogrieste alıyorum
        }
    }
}