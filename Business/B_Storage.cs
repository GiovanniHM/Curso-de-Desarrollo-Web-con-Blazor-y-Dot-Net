using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {

        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        // ----------> Create

        public static void CreateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {

                db.Storages.Add(objStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductinWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                //Revisa si hay algún producto repetido en la bodega
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);
                // Revisa si se cumplio la norma y se activa el boleano
                return product.Any();
            }
        }

        // Update

        public static void UpdateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {

                db.Storages.Update(objStorage);
                db.SaveChanges();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                //Carga el id de los productos hacociados al almacenamiento
                //El método recibe como parámetro el id de la bodega

                return db.Storages.Include(s=>s.Product).Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId == idWarehouse).ToList();
            }
        }
    }
}
