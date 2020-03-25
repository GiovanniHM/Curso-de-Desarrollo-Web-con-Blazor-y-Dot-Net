using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {

        public List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        // ----------> Create

        public static void CreateProduc(ProductEntity objProduc)
        {
            using (var db = new InventaryContext())
            {

                db.Products.Add(objProduc);
                db.SaveChanges();
            }
        }


        // -----------> Update 

        public void UpdateProduc(ProductEntity objProduc)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(objProduc);
                db.SaveChanges();
            }

        }


    }
}
