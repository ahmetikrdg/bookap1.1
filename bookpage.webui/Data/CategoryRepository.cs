using System.Collections.Generic;
using System.Linq;
using bookpage.webui.Models;

namespace bookpage.webui.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories=null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1,Name="Roman",Description="Roman Kategorisi"},
                new Category {CategoryId=2,Name="Bilim",Description="Bilim Kategorisi"},
                new Category {CategoryId=3,Name="Kişisel Gelişim",Description="Kişisel Gelişim Kategorisi"}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int Id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId==Id);
        }

    }
}