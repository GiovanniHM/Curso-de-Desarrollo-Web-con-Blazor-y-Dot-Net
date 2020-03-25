using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
   public class B_InputOutput
    {
        // ----------> List
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        // ----------> Create

        public void CreateInputOutput(InputOutputEntity objInputOutput)
        {
            using (var db = new InventaryContext())
            {

                db.InOuts.Add(objInputOutput);
                db.SaveChanges();
            }
        }


        // -----------> Update 

        public void UpdateInputOutput(InputOutputEntity objInOuts)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(objInOuts);
                db.SaveChanges();
            }

        }


    }
}
