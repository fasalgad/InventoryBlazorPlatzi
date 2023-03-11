using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse //: ICRUData<WarehouseEntity>
    {
        public static void CreateItem(WarehouseEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Warehouses.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(WarehouseEntity item)
        {
            throw new NotImplementedException();
        }

        public static List<WarehouseEntity> ItemList()
        {
            using (var db = new InventaryContenxt())
            {
                return db.Warehouses.ToList();
            }
        }

        public static WarehouseEntity ItemList(string id)
        {
            using (var db = new InventaryContenxt())
            {
                return db.Warehouses.ToList().LastOrDefault(p => p.WarehouseId == id);
            }
        }


        public static void UpdateItem(WarehouseEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Warehouses.Update(item);
                db.SaveChanges();
            }
        }
    }
}
