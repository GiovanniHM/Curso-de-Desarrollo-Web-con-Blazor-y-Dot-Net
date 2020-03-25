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

        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        // ----------> Create

        public void CreateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {

                db.Storages.Add(objStorage);
                db.SaveChanges();
            }
        }

        // Update

        public void UpdateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {

                db.Storages.Update(objStorage);
                db.SaveChanges();
            }
        }
    }
}
