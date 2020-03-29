using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        //Se referencia la clase con la cual llenaremos la lista "CategoryEntity"
        //"CategoryList" solo es un nombre caracteristico (atra vez de ese metodo llegara el 
        //listado de la categoría)
        public static List<CategoryEntity> CategoryList()
        {
            //Llamado interno con un unicio y un final (abre y cierra conexión {})

            using (var db = new InventaryContext())
            {
                //Retorna una lista de categories 
                //Mediante una sentencia Linq
                return db.Categories.ToList();
            }
        }

        //Pasamos un obj como prarametro para cargar los datos (CategoryEntity objCategory)
        public static void CreateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventaryContext())
            {
                //nos conectamos a la bd de acuerdo al contexto que se creo
                //agregamos el objCategory que pasamos al metodo
                db.Categories.Add(objCategory);
                //Guardamos los cambios que pasamos 
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(objCategory);
                db.SaveChanges();
            }

        }

        public static CategoryEntity CategoryById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(c => c.CategoryId == id);
            }

        }
    }
}
