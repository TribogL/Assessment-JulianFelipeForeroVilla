using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedMourners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "6530 Brenna Lane", 58, new DateTime(1996, 11, 14, 3, 3, 35, 915, DateTimeKind.Local).AddTicks(7017), "Antoinette.Bosco@yahoo.com", "Connie", "Female", "Bogisich", "puaeeiee", "876.464.2089 x656" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "194 Medhurst Rapids", 57, new DateTime(1985, 1, 26, 2, 10, 34, 809, DateTimeKind.Local).AddTicks(1581), "Nyah_Veum@gmail.com", "Orland", "Male", "Emmerich", "raeuoaoa", "953.609.4984 x79419" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "94115 Prohaska Field", 31, new DateTime(2000, 6, 21, 7, 39, 58, 696, DateTimeKind.Local).AddTicks(3821), "Stanford97@yahoo.com", "Emie", "Male", "Brakus", "biouaioa", "1-876-663-2331" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "106 Frieda Points", 63, new DateTime(1944, 2, 28, 14, 40, 48, 428, DateTimeKind.Local).AddTicks(8205), "Hadley.Schamberger25@yahoo.com", "Mafalda", "Female", "Sawayn", "peeaoaoa", "1-349-929-5629 x354" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "697 Fisher Route", 84, new DateTime(1979, 10, 18, 3, 34, 23, 201, DateTimeKind.Local).AddTicks(6530), "Catharine.Feeney81@gmail.com", "Joanie", "Other", "Orn", "loioieiu", "1-307-662-7853 x925" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "504 Vincent Glen", 28, new DateTime(1971, 5, 29, 13, 26, 11, 193, DateTimeKind.Local).AddTicks(9013), "Karlie.Romaguera84@gmail.com", "Laney", "Female", "Lemke", "qooieeii", "1-637-356-6324" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "1857 Predovic Hill", 59, new DateTime(1935, 12, 3, 3, 2, 7, 169, DateTimeKind.Local).AddTicks(7985), "Monique_Cummings95@gmail.com", "Mitchell", "Other", "Koss", "faeiueoa", "(480) 392-6251 x8613" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "0713 Mann Freeway", 98, new DateTime(1932, 8, 1, 10, 16, 29, 990, DateTimeKind.Local).AddTicks(9747), "Jamel.Swaniawski43@gmail.com", "Fletcher", "Male", "McCullough", "qiaoueae", "1-200-349-2371 x464" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "31108 Berge Dale", 34, new DateTime(1990, 10, 3, 1, 51, 32, 640, DateTimeKind.Local).AddTicks(748), "Keyon.Kassulke4@gmail.com", "Roel", "Male", "Blick", "naaiouoo", "(728) 425-2455 x6917" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "52268 Windler Common", 87, new DateTime(1989, 4, 6, 22, 2, 38, 560, DateTimeKind.Local).AddTicks(6577), "Colten.Jakubowski@gmail.com", "Margie", "Ledner", "lueuauua", "760.674.3169" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "1645 Ewell Hill", 85, new DateTime(1992, 1, 1, 17, 31, 51, 373, DateTimeKind.Local).AddTicks(5907), "Buck.Klein70@hotmail.com", "Lupe", "Other", "Hermiston", "doeoiaai", "(361) 474-1501 x267" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "4459 Kiara Walk", 32, new DateTime(1940, 8, 25, 17, 21, 25, 81, DateTimeKind.Local).AddTicks(3377), "Eldridge29@hotmail.com", "Eliane", "Other", "Boyle", "veooeaoe", "413.816.2343 x2720" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "6787 Kathlyn Meadows", 35, new DateTime(2005, 2, 24, 19, 7, 39, 335, DateTimeKind.Local).AddTicks(5986), "Burdette.McKenzie76@hotmail.com", "Demario", "Female", "Shanahan", "taaaouoa", "980-798-4443" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "4347 Muller Parkway", 18, new DateTime(1976, 10, 13, 0, 16, 36, 549, DateTimeKind.Local).AddTicks(9073), "Merle_Mohr67@gmail.com", "Margarita", "Other", "Stanton", "vaaoaeie", "450-551-8694 x755" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "1502 Brooks Gateway", 54, new DateTime(1974, 3, 24, 13, 45, 28, 760, DateTimeKind.Local).AddTicks(4401), "Aileen6@hotmail.com", "Alvina", "Female", "Dietrich", "baueiuoi", "225.418.8380" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "624 Larue Inlet", 96, new DateTime(1980, 11, 28, 16, 59, 43, 896, DateTimeKind.Local).AddTicks(5566), "Katherine_Huels@yahoo.com", "Kolby", "Male", "Nader", "faieoeae", "221.656.2079 x90863" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "41761 Zachariah Brook", 56, new DateTime(1967, 5, 31, 4, 57, 48, 774, DateTimeKind.Local).AddTicks(7263), "Cordell16@gmail.com", "Mollie", "Male", "Becker", "qoaouooo", "818.708.7437 x2453" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "19845 Johnson Greens", 22, new DateTime(1980, 2, 25, 14, 14, 28, 950, DateTimeKind.Local).AddTicks(5097), "Opal.Beier@gmail.com", "Jarrett", "Other", "Deckow", "soeuauui", "693.217.1420 x451" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "10124 Block Drive", 66, new DateTime(1953, 11, 19, 20, 38, 8, 637, DateTimeKind.Local).AddTicks(3216), "Kayleigh.Kutch50@hotmail.com", "Ross", "Female", "Bosco", "qauueeea", "(810) 788-3349 x570" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "58643 Borer Lights", 82, new DateTime(1957, 8, 9, 20, 2, 45, 819, DateTimeKind.Local).AddTicks(4901), "Howard.Kihn@gmail.com", "Roderick", "Johnson", "cieuiaee", "871-547-6164" });
        }
    }
}
