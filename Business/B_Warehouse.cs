using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {

        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        // ----------> Create

        public static void CreateWarehouse(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {

                db.Warehouses.Add(objWarehouse);
                db.SaveChanges();
            }
        }

        // Update

        public static void UpdateWarehouse(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {

                db.Warehouses.Update(objWarehouse);
                db.SaveChanges();
            }
        }

        public static WarehouseEntity WarehoseById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(w => w.WarehouseId == id);
            }
        }


    }
}
