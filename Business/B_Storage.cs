using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
