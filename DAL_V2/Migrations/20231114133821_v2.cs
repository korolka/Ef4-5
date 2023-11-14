using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_V2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ActionPrice = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionField1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionField2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => new { x.ProductId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Cart_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeyLink",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeyWordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyLink", x => new { x.ProductId, x.KeyWordId });
                    table.ForeignKey(
                        name: "FK_KeyLink_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeyLink_Words_KeyWordId",
                        column: x => x.KeyWordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { new Guid("10db6307-3954-4c1d-990e-51a243e559b0"), "favicon.ico", "Newspaper" },
                    { new Guid("7d96cbe7-4040-4d53-90ee-da8dab254057"), "favicon.ico", "Magazine" },
                    { new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"), "favicon.ico", "Books" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Login", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("7650d171-d1ce-454d-8561-ae28f65e0f0a"), "email@gmail.com", "tom1996", "Tom", "strongPassword" },
                    { new Guid("ee42391c-9ee1-4ee4-b803-9ddbe5c20f00"), "johm.email@gmail.com", "john_5709", "John", "strongPassword2" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Header", "Keyword" },
                values: new object[,]
                {
                    { new Guid("0f774494-c364-4d45-9946-96688f9bc57d"), null, "development" },
                    { new Guid("35e5636e-9a5f-459b-bafd-da31b43e46c1"), null, "magazine" },
                    { new Guid("42f8c413-093d-4e7d-8e5d-7990e7ea75ed"), null, "spiegel" },
                    { new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb"), null, "book" },
                    { new Guid("f74870d3-744f-4c58-a5d7-b442e5022875"), null, "news" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ActionPrice", "CategoryId", "Description", "DescriptionField1", "DescriptionField2", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("227e013b-3313-4d03-8cbb-c01a0f3cc383"), 1.0, new Guid("10db6307-3954-4c1d-990e-51a243e559b0"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "Financial times", 2.0 },
                    { new Guid("4f2ece48-703e-4e5e-b1b4-c51efe228695"), 2.1000000000000001, new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "Java programming", 3.8500000000000001 },
                    { new Guid("74455efe-9d9b-4235-ae9c-00d40871acba"), 1.0, new Guid("10db6307-3954-4c1d-990e-51a243e559b0"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "NY Times", 1.99 },
                    { new Guid("db2db7d9-8837-455a-af64-892deef5386a"), 1.0, new Guid("7d96cbe7-4040-4d53-90ee-da8dab254057"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "Spiegel", 1.53 },
                    { new Guid("f127e7cd-5390-4475-9376-7ac4992d22fa"), 2.8999999999999999, new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "CLR Programming", 5.5 },
                    { new Guid("f6f45419-7834-43ca-a53a-318a8abd7887"), 2.8999999999999999, new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "Using patterns", 3.2000000000000002 },
                    { new Guid("fb476203-d61a-41d8-b159-ec0e5f679ee6"), 1.0, new Guid("7d96cbe7-4040-4d53-90ee-da8dab254057"), "Lorem ipsum", "Lorem ipsum", "Lorem ipsum", "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg", "Forbes", 1.74 }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "ProductId", "UserId" },
                values: new object[,]
                {
                    { new Guid("74455efe-9d9b-4235-ae9c-00d40871acba"), new Guid("7650d171-d1ce-454d-8561-ae28f65e0f0a") },
                    { new Guid("db2db7d9-8837-455a-af64-892deef5386a"), new Guid("ee42391c-9ee1-4ee4-b803-9ddbe5c20f00") },
                    { new Guid("fb476203-d61a-41d8-b159-ec0e5f679ee6"), new Guid("7650d171-d1ce-454d-8561-ae28f65e0f0a") }
                });

            migrationBuilder.InsertData(
                table: "KeyLink",
                columns: new[] { "KeyWordId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("f74870d3-744f-4c58-a5d7-b442e5022875"), new Guid("227e013b-3313-4d03-8cbb-c01a0f3cc383") },
                    { new Guid("0f774494-c364-4d45-9946-96688f9bc57d"), new Guid("4f2ece48-703e-4e5e-b1b4-c51efe228695") },
                    { new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb"), new Guid("4f2ece48-703e-4e5e-b1b4-c51efe228695") },
                    { new Guid("f74870d3-744f-4c58-a5d7-b442e5022875"), new Guid("74455efe-9d9b-4235-ae9c-00d40871acba") },
                    { new Guid("35e5636e-9a5f-459b-bafd-da31b43e46c1"), new Guid("db2db7d9-8837-455a-af64-892deef5386a") },
                    { new Guid("42f8c413-093d-4e7d-8e5d-7990e7ea75ed"), new Guid("db2db7d9-8837-455a-af64-892deef5386a") },
                    { new Guid("f74870d3-744f-4c58-a5d7-b442e5022875"), new Guid("db2db7d9-8837-455a-af64-892deef5386a") },
                    { new Guid("0f774494-c364-4d45-9946-96688f9bc57d"), new Guid("f127e7cd-5390-4475-9376-7ac4992d22fa") },
                    { new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb"), new Guid("f127e7cd-5390-4475-9376-7ac4992d22fa") },
                    { new Guid("0f774494-c364-4d45-9946-96688f9bc57d"), new Guid("f6f45419-7834-43ca-a53a-318a8abd7887") },
                    { new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb"), new Guid("f6f45419-7834-43ca-a53a-318a8abd7887") },
                    { new Guid("35e5636e-9a5f-459b-bafd-da31b43e46c1"), new Guid("fb476203-d61a-41d8-b159-ec0e5f679ee6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyLink_KeyWordId",
                table: "KeyLink",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "KeyLink");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
