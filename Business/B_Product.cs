using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product //: ICRUData<ProductEntity>
    {
        public static void CreateItem(ProductEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(ProductEntity item)
        {
            throw new NotImplementedException();
        }

        public static List<ProductEntity> ItemList()
        {
            using (var db = new InventaryContenxt())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ItemList(string id)
        {
            using (var db = new InventaryContenxt())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        

        public static void UpdateItem(ProductEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Products.Update(item);
                db.SaveChanges();
            }
        }
    }
}
