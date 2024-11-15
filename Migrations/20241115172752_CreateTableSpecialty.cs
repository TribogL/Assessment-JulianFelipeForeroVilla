using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableSpecialty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties");

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "specialty",
                table: "doctors");

            migrationBuilder.RenameTable(
                name: "Specialties",
                newName: "specialties");

            migrationBuilder.AddColumn<int>(
                name: "specialty_id",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "specialty_id1",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_specialties",
                table: "specialties",
                column: "id");

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "0139 Konopelski Turnpike", 38, new DateTime(1956, 5, 8, 18, 4, 12, 469, DateTimeKind.Local).AddTicks(9249), "Maye.Schoen25@yahoo.com", "Stacey", "Toy", "veaiiooo", "446-476-8517" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "2064 Wunsch Road", 24, new DateTime(1953, 12, 17, 12, 32, 19, 806, DateTimeKind.Local).AddTicks(3147), "Mathias_Conroy55@hotmail.com", "Alberto", "Kub", "cuooiuia", "257-547-1923" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "6938 Sincere Circles", 68, new DateTime(1942, 12, 1, 21, 43, 41, 706, DateTimeKind.Local).AddTicks(2977), "Paxton_Brown56@hotmail.com", "Velma", "Other", "Halvorson", "rueeooue", "629-439-8091 x030" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "7856 Sabryna Vista", 99, new DateTime(1950, 3, 11, 10, 24, 24, 877, DateTimeKind.Local).AddTicks(2229), "Josie.VonRueden@gmail.com", "Rosemarie", "Female", "Kemmer", "tiiieiio", "294.884.1718 x071" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "0467 Bonita Plain", 64, new DateTime(1940, 4, 10, 15, 15, 56, 906, DateTimeKind.Local).AddTicks(870), "Oswaldo.OConner83@gmail.com", "Efren", "Mitchell", "caoeeiio", "241-745-7658" });

            migrationBuilder.CreateIndex(
                name: "IX_doctors_specialty_id1",
                table: "doctors",
                column: "specialty_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_specialties_specialty_id1",
                table: "doctors",
                column: "specialty_id1",
                principalTable: "specialties",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specialties_specialty_id1",
                table: "doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_specialties",
                table: "specialties");

            migrationBuilder.DropIndex(
                name: "IX_doctors_specialty_id1",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "specialty_id",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "specialty_id1",
                table: "doctors");

            migrationBuilder.RenameTable(
                name: "specialties",
                newName: "Specialties");

            migrationBuilder.AddColumn<string>(
                name: "specialty",
                table: "doctors",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties",
                column: "id");

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "This Specialty is for patients", "Patient" },
                    { 2, "This Specialty is for doctors", "Doctor" }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "email", "first_name", "gender", "last_name", "office", "password", "specialty", "Status" },
                values: new object[,]
                {
                    { 1, "Eunice_Cronin89@hotmail.com", "Twila", "Male", "Ritchie", 258, "juaoiaee", "Networked contextually-based data-warehouse", "Vandervort and Sons" },
                    { 2, "Lincoln.Bogan23@hotmail.com", "Angeline", "Male", "Gulgowski", 118, "jeuuiiio", "Customer-focused asymmetric hub", "O'Kon, Johnson and Lynch" },
                    { 3, "Carroll91@hotmail.com", "Lorine", "Other", "Zulauf", 11, "naiaiiau", "Organized zero tolerance contingency", "Schmeler - Yost" },
                    { 4, "Daniella.Conroy24@yahoo.com", "Madonna", "Male", "Graham", 79, "wuoeooua", "User-centric empowering forecast", "Reichel - Koepp" },
                    { 5, "Eric.Morissette@gmail.com", "Stephon", "Female", "Rogahn", 51, "kiieoaoo", "Organized client-driven emulation", "Towne - Schaden" },
                    { 6, "Shaylee_Kub@gmail.com", "Clint", "Female", "Walter", 289, "beoiueee", "Compatible didactic forecast", "Abshire, Abernathy and Luettgen" },
                    { 7, "Keara_Kuhic@yahoo.com", "Noemy", "Male", "Morissette", 154, "neoioioa", "Profit-focused cohesive policy", "Kiehn, Gleichner and Prohaska" },
                    { 8, "Sim.Sporer@yahoo.com", "Brycen", "Other", "Cartwright", 110, "nuaeooiu", "Fundamental tertiary matrix", "Rolfson, Hagenes and Hettinger" },
                    { 9, "Raina14@yahoo.com", "Greyson", "Female", "Connelly", 255, "riuuouau", "User-centric fresh-thinking projection", "Strosin Inc" },
                    { 10, "Joaquin89@gmail.com", "Kacey", "Female", "Donnelly", 293, "voioioeo", "Upgradable disintermediate budgetary management", "Jaskolski LLC" }
                });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "17470 Daugherty Common", 37, new DateTime(2000, 5, 27, 14, 52, 6, 445, DateTimeKind.Local).AddTicks(4605), "Katlynn_Baumbach73@gmail.com", "Rowland", "Keeling", "vaiuueeo", "617.397.9224 x193" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "340 Gaylord Street", 44, new DateTime(1941, 3, 6, 10, 12, 9, 81, DateTimeKind.Local).AddTicks(6323), "Twila.White@hotmail.com", "Mae", "Female", "Bartell", "bioooauu", "991-545-8010" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "04437 Fisher Expressway", 91, new DateTime(1984, 7, 23, 18, 12, 44, 923, DateTimeKind.Local).AddTicks(1995), "Gerson79@gmail.com", "Pascale", "Mraz", "joaaioui", "507-253-1724 x89904" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "3296 Feeney Viaduct", 33, new DateTime(1991, 5, 22, 1, 33, 58, 348, DateTimeKind.Local).AddTicks(4047), "Nedra_Okuneva31@yahoo.com", "Soledad", "Female", "Nitzsche", "fiueuuee", "929.990.0778 x240" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "77321 Delia Route", 35, new DateTime(2001, 7, 21, 13, 23, 54, 132, DateTimeKind.Local).AddTicks(813), "Sunny80@gmail.com", "Adolf", "Bergstrom", "zuoeoaui", "(296) 413-2320 x733" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "4037 Cary Rest", 93, new DateTime(1995, 4, 28, 1, 2, 59, 257, DateTimeKind.Local).AddTicks(6626), "Haylie_Powlowski@gmail.com", "Bruce", "Female", "Hauck", "muioioaa", "700-815-3569" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "7689 Ronaldo Courts", 74, new DateTime(1977, 1, 26, 3, 38, 56, 770, DateTimeKind.Local).AddTicks(9115), "Jerel_Steuber98@hotmail.com", "Gertrude", "Other", "Corwin", "waauaiou", "965.292.8904" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "24124 Hardy Mountains", 68, new DateTime(1964, 12, 22, 0, 59, 1, 852, DateTimeKind.Local).AddTicks(8133), "Jovany_Simonis@gmail.com", "Dominique", "Male", "Kozey", "kaoiooeu", "(388) 624-0334 x5547" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "04292 Yundt Underpass", 38, new DateTime(1966, 10, 27, 15, 53, 10, 27, DateTimeKind.Local).AddTicks(7563), "Jennings.Wehner27@gmail.com", "Deron", "Haag", "leiueoio", "246-476-8176 x59396" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "54741 Adelia Crossroad", 73, new DateTime(1970, 8, 8, 10, 12, 58, 284, DateTimeKind.Local).AddTicks(208), "Jaquelin_Zemlak16@hotmail.com", "Felix", "Ortiz", "xaiaiaiu", "704-489-5301" });
        }
    }
}
