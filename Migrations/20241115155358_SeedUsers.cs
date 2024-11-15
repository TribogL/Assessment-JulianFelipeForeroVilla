using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number" },
                values: new object[] { "47152 Labadie Fort", 91, new DateTime(1972, 8, 6, 15, 2, 47, 874, DateTimeKind.Local).AddTicks(8099), "Celine15@gmail.com", "Lera", "Male", "Gottlieb", "nieouauo", "614-247-2021" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "57909 Rempel Shoals", 53, new DateTime(1954, 2, 23, 2, 25, 1, 478, DateTimeKind.Local).AddTicks(5165), "Nicholaus92@hotmail.com", "Sean", "Murazik", "soeeaeao", "450.706.0421", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "09524 Joelle Ridge", 85, new DateTime(2002, 7, 8, 17, 35, 46, 862, DateTimeKind.Local).AddTicks(1055), "Sally8@gmail.com", "Myrtle", "Wyman", "poieaouo", "(656) 873-5819", 1 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "0785 Daron Divide", 71, new DateTime(1989, 8, 24, 5, 45, 32, 251, DateTimeKind.Local).AddTicks(973), "Cara.Waters@hotmail.com", "Ramiro", "Female", "Kub", "woieooea", "581-532-7648 x60036", 1 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "17609 Oscar Coves", 49, new DateTime(1947, 1, 25, 15, 23, 45, 972, DateTimeKind.Local).AddTicks(3251), "Tyshawn_Lebsack@yahoo.com", "Olga", "Steuber", "fuiioauo", "534.984.0426", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "1531 Prosacco Mountains", 99, new DateTime(2002, 11, 25, 2, 20, 48, 118, DateTimeKind.Local).AddTicks(7164), "Jaime.Nicolas26@yahoo.com", "Finn", "Female", "Feeney", "neiieiie", "616.703.8000 x5185", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "4121 Stokes Hill", 62, new DateTime(2006, 8, 11, 7, 38, 49, 34, DateTimeKind.Local).AddTicks(8199), "Felipa_Quitzon32@gmail.com", "Annabel", "Purdy", "seieuaiu", "954-771-1529", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number" },
                values: new object[] { "74860 Hamill Trace", 25, new DateTime(1994, 6, 10, 14, 30, 59, 178, DateTimeKind.Local).AddTicks(4357), "Noemi98@yahoo.com", "Cristina", "Female", "Prohaska", "kauaoeoa", "256-776-1882" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number" },
                values: new object[] { "48656 Constantin Flat", 38, new DateTime(1979, 2, 4, 23, 3, 10, 915, DateTimeKind.Local).AddTicks(4901), "Narciso_Schoen55@yahoo.com", "Kenya", "Female", "Satterfield", "tieiuoee", "838-485-0715 x9351" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "75073 Gregory Drive", 64, new DateTime(1954, 8, 31, 5, 44, 18, 379, DateTimeKind.Local).AddTicks(5812), "Davon78@hotmail.com", "Josiah", "Female", "Boyer", "souiuuou", "647-775-3608", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number" },
                values: new object[] { "523 Reyes Vista", 34, new DateTime(2004, 5, 5, 18, 15, 29, 684, DateTimeKind.Local).AddTicks(2408), "Jeanne.Hudson@yahoo.com", "Terry", "Female", "Bartell", "tuaeuaua", "1-572-624-9558 x777" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "80617 Hauck Gateway", 63, new DateTime(1929, 9, 4, 7, 47, 18, 703, DateTimeKind.Local).AddTicks(8629), "Hildegard85@hotmail.com", "Hoyt", "Berge", "joaeeiao", "1-997-766-6888 x3850", 1 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "8943 Emiliano Oval", 60, new DateTime(1949, 11, 6, 11, 32, 29, 957, DateTimeKind.Local).AddTicks(6163), "Dixie70@hotmail.com", "Stephania", "Monahan", "louoioou", "873-484-9501 x83798", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "7535 Flo Road", 67, new DateTime(1949, 9, 25, 16, 25, 45, 794, DateTimeKind.Local).AddTicks(1832), "Randi_Nicolas@gmail.com", "Tyler", "Male", "Macejkovic", "vaeieieo", "697.983.2219", 2 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "265 Mohr Cape", 56, new DateTime(1949, 8, 15, 17, 18, 12, 379, DateTimeKind.Local).AddTicks(5509), "Dameon_Robel@hotmail.com", "Reid", "Dare", "hiuioeiu", "848-418-5106 x0072", 1 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "38842 O'Keefe Expressway", 22, new DateTime(1986, 1, 27, 17, 48, 44, 366, DateTimeKind.Local).AddTicks(1416), "Mireille_Walker@gmail.com", "Zoe", "Male", "Heaney", "paiiuuiu", "(916) 238-9400", 1 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "674 Araceli Garden", 96, new DateTime(1971, 4, 7, 8, 47, 26, 6, DateTimeKind.Local).AddTicks(7837), "Llewellyn_Jenkins19@hotmail.com", "Hermina", "Corkery", "kiuiaaau", "558-732-2413 x709", 1 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number" },
                values: new object[] { "0594 Mohr Curve", 20, new DateTime(1977, 2, 22, 15, 10, 11, 140, DateTimeKind.Local).AddTicks(2784), "Tyrique.Dooley3@yahoo.com", "Jenifer", "Male", "Hackett", "gueuaeuo", "(615) 285-7098 x6235" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number" },
                values: new object[] { "425 Rico Ways", 65, new DateTime(1974, 4, 22, 12, 17, 28, 355, DateTimeKind.Local).AddTicks(9519), "Damon_Batz@yahoo.com", "Leatha", "Other", "Beier", "touiauae", "728-299-6688 x0249" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "Password", "phone_number", "rol_id" },
                values: new object[] { "27737 Brice Shores", 63, new DateTime(1948, 9, 18, 2, 36, 41, 255, DateTimeKind.Local).AddTicks(6995), "Cristobal24@hotmail.com", "Cordie", "Male", "Hayes", "yooaiaeu", "(546) 959-6142 x2663", 1 });
        }
    }
}
