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

        public List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        // ----------> Create

        public void CreateWarehouse(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {

                db.Warehouses.Add(objWarehouse);
                db.SaveChanges();
            }
        }

        // Update

        public void UpdateWarehouse(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {

                db.Warehouses.Update(objWarehouse);
                db.SaveChanges();
            }
        }


    }
}
