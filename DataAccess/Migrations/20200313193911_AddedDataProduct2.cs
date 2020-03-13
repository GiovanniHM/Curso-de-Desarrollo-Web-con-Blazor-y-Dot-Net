using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedDataProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "0bb050fa-c599-4e4e-a0cb-56188b92a85a");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "92d0a259-55ed-4f77-add0-0bc49f7c149f");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[,]
                {
                    { "ASJ-98745", "PRF", "", "Crema para manos marca Tersa", 0 },
                    { "RPT-54658", "SLD", "", "Pastillas para la garganta LESUS", 0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "cbf3a9de-3079-4a1d-b9f5-74dc4a3d7fd0", "Calle 8 con 23", "Bodega Central" },
                    { "29c0c84d-b637-4613-8d9d-5545fbc5dccd", "Calle norte con occidente", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ASJ-98745");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "RPT-54658");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "29c0c84d-b637-4613-8d9d-5545fbc5dccd");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "cbf3a9de-3079-4a1d-b9f5-74dc4a3d7fd0");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "0bb050fa-c599-4e4e-a0cb-56188b92a85a", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "92d0a259-55ed-4f77-add0-0bc49f7c149f", "Calle norte con occidente", "Bodega Norte" });
        }
    }
}
