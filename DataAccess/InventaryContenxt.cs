using System;
using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class InventaryContenxt:DbContext
    {
        public DbSet<ProductEntity> Products { set; get; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string bd = "";
                string pass = "";
                string user = "";
                
                
                string con = "Server=tcp:"+bd+",1433;Initial Catalog=InventoryDb;Persist Security Info=False;User ID="+user+";Password="+pass+";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                options.UseSqlServer(con); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH",CategoryName="Aseo Hogar"},
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId=Guid.NewGuid().ToString(), WarehouseName="Bodega 1",WarehouseAddress = "Matriz"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega 2", WarehouseAddress = "Sucursal" }
                );
        }
    }
}
