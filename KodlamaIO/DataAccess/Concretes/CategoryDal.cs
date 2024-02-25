using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "Yapay Zeka";
            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategoryName = "Algoritma Yapıları";

            categories = new List<Category> {category1,category2};
        }
        public List<Category> GetAll()
        {
            return categories;
        }
        public void Create(Category category)
        {
            int sayac = 0;
            foreach (var item in categories)
            {
                if (item == category)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                categories.Add(category);
                Console.WriteLine("Kategori başarı ile eklendi.");
            }
            else
            {
                Console.WriteLine("Ekli olan bir Kategoriyi ekleyemezsiniz.");
            }
        }
        public void Delete(Category category)
        {
            int sayac = 1;
            foreach (var item in categories)
            {
                if (item == category)
                {
                    categories.Remove(category);
                    sayac--;
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("Kategori başarı ile silindi.");
            }
            else
            {
                Console.WriteLine("Silmek istediğiniz Kategori sistemimizde zaten kayıtlı değil!!");
            }
        }
        public void Update(Category category)
        {
            int sayac = 1;
            foreach (var item in categories)
            {
                if (item.CategoryId == category.CategoryId)
                {
                    categories.Remove(category);
                    sayac--;
                }
            }
            if (sayac == 0)
            {
                categories.Add(category);
                Console.WriteLine("Kategori başarı ile güncellendi.");
            }
            else
            {
                Console.WriteLine("Güncellemek istediğiniz Kategori sistemimizde zaten kayıtlı değil!!");
            }
        }
    }
}
