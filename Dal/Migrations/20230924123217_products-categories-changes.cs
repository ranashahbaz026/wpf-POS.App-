using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class productscategorieschanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderProducts",
                newName: "OrderProduct");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Products",
                newName: "Product_Name");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Selling_Price");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "Category_ID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedBy",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Minimum_Stock_Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sub_Category_ID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Order",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Order",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderProduct",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OrderProduct",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderProduct",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "OrderProduct",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_ID = table.Column<int>(type: "int", nullable: false),
                    Sub_Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Category_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Minimum_Stock_Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Sub_Category_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "OrderProduct",
                newName: "OrderProducts");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "Selling_Price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Product_Name",
                table: "Products",
                newName: "Size");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
