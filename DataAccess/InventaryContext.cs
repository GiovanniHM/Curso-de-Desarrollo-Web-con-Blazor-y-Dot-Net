using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext:DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity>Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Chain of connection 
            if(!options.IsConfigured)
            {
                //Specific connection for sql server
                options.UseSqlServer("Server =DESKTOP-QVGSU4R; Database=InvetoryDb; User Id=; Password=");
            }
        }

    }
}
