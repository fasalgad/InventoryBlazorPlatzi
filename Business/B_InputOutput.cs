using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput //: ICRUData<InputOutputEntity>
    {
        public static void CreateItem(InputOutputEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.InputOutputs.Add(item);
                db.SaveChanges();
            }
        }

        public static void DeleteItem(InputOutputEntity item)
        {
            throw new NotImplementedException();
        }

        public static List<InputOutputEntity> ItemList()
        {
            using (var db = new InventaryContenxt())
            {
                return db.InputOutputs.ToList();
            }
        }

        public static void UpdateItem(InputOutputEntity item)
        {
            using (var db = new InventaryContenxt())
            {
                db.InputOutputs.Update(item);
                db.SaveChanges();
            }
        }
    }
}
