using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage //: ICRUData<StorageEntity>
    {
        public static void CreateItem(StorageEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(StorageEntity item)
        {
            throw new NotImplementedException();
        }

        public static List<StorageEntity> ItemList()
        {
            using (var db = new InventaryContenxt())
            {
                return db.Storages.ToList();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehose(string idWarehouse)
        {
            using (var db = new InventaryContenxt())
            {
                return db.Storages.Where(s => s.WarehouseId == idWarehouse)
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse) 
                    .ToList();
            }
        }

        public static bool IsProductInWarehouse(string productWarehouse)
        {
            using (var db = new InventaryContenxt())
            {

                return db.Storages.Where(p => p.StorageId == productWarehouse).Any();
            }
        }

        public static void UpdateItem(StorageEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }
    }
}
