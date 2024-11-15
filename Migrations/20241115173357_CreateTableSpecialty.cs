using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableSpecialty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "4292 Weissnat Vista", 90, new DateTime(1988, 5, 11, 8, 22, 6, 279, DateTimeKind.Local).AddTicks(9466), "Shad54@yahoo.com", "Lambert", "Male", "Bernier", "heeaeooa", "1-438-253-5052 x961" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "7322 Albertha Corners", 95, new DateTime(1994, 3, 25, 13, 17, 13, 920, DateTimeKind.Local).AddTicks(2785), "Micaela_Kunde@gmail.com", "Jerod", "Female", "Brown", "seooaeoa", "(274) 918-1246 x5249" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "13628 Raynor Villages", 32, new DateTime(1963, 6, 3, 16, 42, 8, 230, DateTimeKind.Local).AddTicks(4060), "Griffin.Swift48@hotmail.com", "Katelyn", "Male", "Lockman", "vuaaaoae", "1-212-459-4751" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "525 Myles View", 83, new DateTime(1952, 7, 31, 9, 44, 47, 936, DateTimeKind.Local).AddTicks(7262), "Jacquelyn10@yahoo.com", "Mohammed", "Female", "Berge", "geuaeuea", "275.793.2473 x30899" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "2670 Donato Creek", 81, new DateTime(1953, 6, 8, 8, 2, 13, 120, DateTimeKind.Local).AddTicks(8101), "Frederick4@yahoo.com", "Pierce", "Upton", "meiuoeoa", "882-513-0495" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "75911 Dameon Route", 79, new DateTime(1937, 7, 28, 15, 42, 29, 754, DateTimeKind.Local).AddTicks(1446), "Irving_Mann@gmail.com", "Marilie", "Weimann", "siiooaou", "1-990-458-5381 x4536" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "12501 Champlin Terrace", 65, new DateTime(1940, 7, 13, 22, 19, 29, 399, DateTimeKind.Local).AddTicks(199), "Arthur39@hotmail.com", "Jalen", "Maggio", "feueeeoe", "212.799.8407 x839" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "653 Addie Views", 77, new DateTime(1978, 7, 8, 8, 59, 50, 766, DateTimeKind.Local).AddTicks(470), "Samantha41@yahoo.com", "Ima", "Female", "Runte", "peeuuooa", "1-278-813-8626" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "510 Eryn Ports", 47, new DateTime(1935, 7, 20, 0, 4, 54, 797, DateTimeKind.Local).AddTicks(3707), "Van_Morar@hotmail.com", "Bulah", "Windler", "veiuuoee", "1-595-814-1065" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "34561 Benedict Rapid", 69, new DateTime(1984, 4, 8, 1, 40, 37, 840, DateTimeKind.Local).AddTicks(5376), "Osvaldo_Champlin@gmail.com", "Chanel", "Female", "Reilly", "laaauaio", "734-280-2842" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "0139 Konopelski Turnpike", 38, new DateTime(1956, 5, 8, 18, 4, 12, 469, DateTimeKind.Local).AddTicks(9249), "Maye.Schoen25@yahoo.com", "Stacey", "Other", "Toy", "veaiiooo", "446-476-8517" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "031 Zoie Pines", 28, new DateTime(1958, 4, 23, 17, 43, 14, 887, DateTimeKind.Local).AddTicks(5275), "Nikita33@gmail.com", "Hank", "Male", "Rutherford", "zaoaeuua", "652-489-1306 x749" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "2064 Wunsch Road", 24, new DateTime(1953, 12, 17, 12, 32, 19, 806, DateTimeKind.Local).AddTicks(3147), "Mathias_Conroy55@hotmail.com", "Alberto", "Female", "Kub", "cuooiuia", "257-547-1923" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "8457 Kristian Village", 93, new DateTime(1943, 9, 29, 5, 25, 37, 233, DateTimeKind.Local).AddTicks(4202), "Julien_Mayert99@hotmail.com", "Everette", "Male", "Lebsack", "riooeioa", "330-491-2873 x107" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "7944 Dayna Via", 22, new DateTime(1931, 7, 29, 5, 37, 28, 804, DateTimeKind.Local).AddTicks(2813), "Olaf.Brown@hotmail.com", "Carmen", "Nader", "woiuuaie", "813.311.2074 x60398" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "6938 Sincere Circles", 68, new DateTime(1942, 12, 1, 21, 43, 41, 706, DateTimeKind.Local).AddTicks(2977), "Paxton_Brown56@hotmail.com", "Velma", "Halvorson", "rueeooue", "629-439-8091 x030" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "7856 Sabryna Vista", 99, new DateTime(1950, 3, 11, 10, 24, 24, 877, DateTimeKind.Local).AddTicks(2229), "Josie.VonRueden@gmail.com", "Rosemarie", "Kemmer", "tiiieiio", "294.884.1718 x071" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "3912 Crooks Green", 46, new DateTime(1994, 1, 4, 0, 20, 26, 208, DateTimeKind.Local).AddTicks(9872), "Kacey_Bednar@hotmail.com", "Rylan", "Other", "Bartell", "deuieuio", "1-320-451-4113" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "481 Gustave Lodge", 97, new DateTime(2000, 8, 23, 12, 17, 36, 866, DateTimeKind.Local).AddTicks(8367), "Jared_Hessel@yahoo.com", "Elza", "Heaney", "qieeouue", "916-976-0779" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "0467 Bonita Plain", 64, new DateTime(1940, 4, 10, 15, 15, 56, 906, DateTimeKind.Local).AddTicks(870), "Oswaldo.OConner83@gmail.com", "Efren", "Other", "Mitchell", "caoeeiio", "241-745-7658" });
        }
    }
}
