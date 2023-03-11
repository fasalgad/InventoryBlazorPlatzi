using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Category // : ICRUData<CategoryEntity>
    {
       
        public static void CreateItem(CategoryEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(CategoryEntity item)
        {
            throw new NotImplementedException();
        }

        public static List<CategoryEntity> ItemList()
        {
            using (var db = new InventaryContenxt())
            {
                return db.Categories.ToList();
            }
        }
        public static CategoryEntity ItemList(string id)
        {
            using (var db = new InventaryContenxt())
            {
                return db.Categories.ToList().LastOrDefault(p => p.CategoryId == id);
            }
        }


        public static void UpdateItem(CategoryEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }
    }
}
