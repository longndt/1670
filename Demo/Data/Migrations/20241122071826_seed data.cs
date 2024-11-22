using Microsoft.EntityFrameworkCore.Migrations;

namespace Tut3.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Laptop",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin-role",
                column: "ConcurrencyStamp",
                value: "a0fd3158-a861-4ded-9f32-3e1dfa2c1b8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user-role",
                column: "ConcurrencyStamp",
                value: "4c091e43-def0-47ee-9667-6783ff7ed1af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4d06cd8-d86d-40b1-8c4d-462fe2b83084", "AQAAAAEAACcQAAAAEAUrb659KD6X1NuZURqg2yH7Q6pvVoq1ezswrmXlpE5y0+HNsg1QERJ5Uuk4dOxOPg==", "6b85fe43-10bb-4dcb-bca0-525de3b103e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "115febe7-7fe8-4e1e-b6b1-6c4e04fbc637", "AQAAAAEAACcQAAAAEPv1KojRDLqN5/v6OUcMDA5C5QFZAEmVnJ6LQiMwQR5Se92uZyjHdPdgF27l/gOW0w==", "a968fad2-e3eb-49b5-b999-bfaa5c5b357f" });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gaming" },
                    { 2, "Business" },
                    { 3, "Ultrabook" },
                    { 4, "Convertible" },
                    { 5, "Workstation" },
                    { 6, "Budget" },
                    { 7, "Chromebook" },
                    { 8, "2-in-1" },
                    { 9, "Performance" },
                    { 10, "Gaming Ultra" }
                });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "BrandId", "Color", "Image", "Model", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Black", "https://example.com/asus-tuf-f15.jpg", "Asus TUF Gaming F15", 999.0, 10 },
                    { 14, 8, "Silver", "https://example.com/galaxy-book-3.jpg", "Samsung Galaxy Book 3", 1249.0, 4 },
                    { 6, 8, "Platinum", "https://example.com/surface-laptop-5.jpg", "Microsoft Surface Laptop 5", 1299.0, 7 },
                    { 19, 7, "Silver", "https://example.com/chromebook-spin-713.jpg", "Chromebook Spin 713", 629.0, 9 },
                    { 16, 6, "Green", "https://example.com/vivobook-s14.jpg", "Asus VivoBook S14", 749.0, 7 },
                    { 12, 6, "Gold", "https://example.com/hp-pavilion-15.jpg", "HP Pavilion 15", 749.0, 10 },
                    { 11, 6, "Black", "https://example.com/dell-inspiron-15.jpg", "Dell Inspiron 15", 699.0, 8 },
                    { 8, 6, "Silver", "https://example.com/acer-swift-3.jpg", "Acer Swift 3", 799.0, 9 },
                    { 3, 4, "Silver", "https://example.com/hp-envy-x360.jpg", "HP Envy x360", 1149.0, 6 },
                    { 17, 3, "Silver", "https://example.com/macbook-pro-14.jpg", "Apple MacBook Pro 14", 1999.0, 10 },
                    { 13, 3, "Gray", "https://example.com/lenovo-ideapad-5.jpg", "Lenovo IdeaPad 5", 849.0, 6 },
                    { 5, 3, "Space Gray", "https://example.com/macbook-air-m2.jpg", "Apple MacBook Air M2", 1199.0, 12 },
                    { 2, 3, "Silver", "https://example.com/dell-xps-13.jpg", "Dell XPS 13", 1399.0, 8 },
                    { 4, 2, "Black", "https://example.com/thinkpad-x1-carbon.jpg", "Lenovo ThinkPad X1 Carbon", 1699.0, 5 },
                    { 18, 1, "Black", "https://example.com/alienware-m15-r7.jpg", "Alienware m15 R7", 2299.0, 4 },
                    { 15, 1, "Black", "https://example.com/msi-katana-gf66.jpg", "MSI Katana GF66", 1049.0, 6 },
                    { 10, 1, "Gray", "https://example.com/rog-zephyrus-g14.jpg", "Asus ROG Zephyrus G14", 1599.0, 5 },
                    { 7, 1, "Black", "https://example.com/razer-blade-15.jpg", "Razer Blade 15", 2499.0, 4 },
                    { 9, 9, "White", "https://example.com/lg-gram-17.jpg", "LG Gram 17", 1799.0, 3 },
                    { 20, 9, "Black", "https://example.com/gigabyte-aero-16.jpg", "Gigabyte Aero 16", 2399.0, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Laptop",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin-role",
                column: "ConcurrencyStamp",
                value: "766407d2-ae08-43d6-88ae-b999b852b344");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user-role",
                column: "ConcurrencyStamp",
                value: "46158f52-2612-47c5-80e8-f593e6f32395");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17763e38-694d-40ee-b86e-73e9b8085ff8", "AQAAAAEAACcQAAAAEOXCYXyQFFMaFMQLgMdblJemY6i2iCgnbnLgXPxC0UlZ4jTsRATpKkv6Ryg6QTZ/OA==", "716db2db-fdbf-406c-ba8e-ea4ca3583f37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b070a3a5-c301-4e08-a542-52ccac95e899", "AQAAAAEAACcQAAAAEIZ2CXExLi1raj4nZRnv7pRYwjfolESto50GJCCXCMnBaTNZ8eP7+Keu0DuK1AKxxA==", "7f06cf9f-7d62-4eb5-939a-ca08d96fb83c" });
        }
    }
}
