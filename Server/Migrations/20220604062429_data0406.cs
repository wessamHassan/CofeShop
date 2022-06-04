using Microsoft.EntityFrameworkCore.Migrations;

namespace CofeShop.Server.Migrations
{
    public partial class data0406 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Scones with organic Swedish blackberry jam.", "Scone with jam _ cream cheese.jpg", "Scone with jam & cream cheese", 45m },
                    { 16, "Classic Frappe Latte on our award winning espresso.", "Classic Frappe Latte.jpg", "Classic Frappe Latte", 35m },
                    { 15, "Italian light bread with pesto, grated mozzarella, fresh tomatoes, prosciutto crudo. Grilled and heated in the oven.", "Grilled pinsa pesto prosciutto.jpg", "Grilled pinsa pesto prosciutto", 60m },
                    { 14, "Italian light bread with pesto  hot tuna in mayonaise jalapenos  tomatoes. Grilled and heated in the oven.", "Grilled pinsa tonno piccante.jpg", "Grilled pinsa tonno piccante", 60m },
                    { 13, "Housemade tabboulhe with spicy hummus pomegranate  olive oil & limepepper.", "Salad tabboulhe with pomegranate _ spicy hummus.jpg", "Salad tabboulhe with pomegranate spicy hummus", 62m },
                    { 12, "Swedish turkey bacon  pesto calabrese farro & boiled egg.", "Salad, Chicken, Turkey bacon, Farro Calabrese _ egg.jpg", "Salad  Turkey bacon & egg", 65m },
                    { 11, "Stuffed premium butter croissant with prosciutto crudo & scrambled egg.", "Croissant prosciutto _ egg.jpg", "Croissant prosciutto egg", 35m },
                    { 10, "Lactose free yoghurt 10% with honey and walnuts.", "Yoghurt honey walnut.jpg", "Yoghurt honey walnut", 40m },
                    { 9, "Danish pastry with sour and fresh lemoncurd blueberries and icing sugar.", "Spandau lemoncurd _ blueberries.jpg", "Spandau lemoncurd & blueberries", 33m },
                    { 8, "Hand-knotted cardamom bun with real butter.", "Cardamom bun premium.jpg", "Cardamom bun premium", 34m },
                    { 7, "An all butter  flaky French pastry rolled into a croissant.", "Butter Croissant.jpg", "Butter Croissant", 32m },
                    { 6, "Espresso with steamed milk, microfoam  and dusted with chocolate powder.", "Cappuccino.jpg", "Cappuccino", 35m },
                    { 5, "Espresso topped with steamed milk and a thin layer of micro-foam.", "Caffe latte.jpg", "Caffè latte", 32m },
                    { 4, "A long black coffee with 2 shots of espresso for regular and 3 for grande.", "Americano.jpg", "Americano", 35m },
                    { 3, "Breakfast roll with cheddar, turkey pastrami, butter, green salad", "Breakfast roll cheddar _ turkey pastrami.jpg", "Breakfast roll cheddar turkey", 43m },
                    { 2, "Breakfast roll with cheddar, butter, green salad & tomato.", "Breakfast roll with cheddar.jpg", "Breakfast roll with cheddar", 40m },
                    { 17, "Classic Iced Latte on our award winning espresso and caramel syrup.", "Ice Latte Caramel.jpg", "Ice Latte Caramel", 42m },
                    { 18, "Classic Iced Latte on our award winning espresso and vanilla syrup.", "Ice Latte Vanilla.jpg", "Ice Latte Vanilla", 42m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 100, " test", "test", "test", 20m });
        }
    }
}
