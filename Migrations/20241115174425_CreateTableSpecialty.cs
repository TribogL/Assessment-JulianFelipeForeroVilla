using System;
using Microsoft.EntityFrameworkCore.Metadata;
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
            

            migrationBuilder.CreateTable(
                name: "specialties",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialties", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specialty_id = table.Column<int>(type: "int", nullable: false),
                    office = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specialty_id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.id);
                    table.ForeignKey(
                        name: "FK_doctors_specialties_specialty_id1",
                        column: x => x.specialty_id1,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "7831 Willow Path", 39, new DateTime(1949, 6, 12, 12, 12, 53, 859, DateTimeKind.Local).AddTicks(1533), "Keanu85@yahoo.com", "Selina", "Male", "Nolan", "lauaueia", "356.524.8605 x0226" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "2465 Bernie Tunnel", 58, new DateTime(1984, 7, 30, 4, 9, 20, 326, DateTimeKind.Local).AddTicks(1345), "Meghan.Marquardt@hotmail.com", "Candace", "Other", "Torphy", "muuioeau", "307.208.6907 x8228" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "68881 Koepp Extensions", 35, new DateTime(1929, 2, 20, 12, 56, 43, 715, DateTimeKind.Local).AddTicks(9374), "Dolores_Becker68@yahoo.com", "Eloise", "Other", "Runolfsson", "keioaeoa", "473.408.0067" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "677 Estevan Roads", 88, new DateTime(1957, 6, 29, 8, 31, 22, 885, DateTimeKind.Local).AddTicks(2765), "Maggie.Wisoky@gmail.com", "Dorthy", "Hilll", "paauuiao", "986-291-3715 x25989" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "39985 Tracey Hills", 49, new DateTime(1945, 5, 12, 7, 9, 50, 667, DateTimeKind.Local).AddTicks(9881), "Fanny.Collier@yahoo.com", "Joana", "Bode", "suoaeieo", "490.475.4782 x08077" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "89203 Homenick Centers", 76, new DateTime(2003, 3, 14, 1, 33, 0, 160, DateTimeKind.Local).AddTicks(1007), "Brent.Green@yahoo.com", "Elroy", "Jacobs", "cuoeaeaa", "1-486-591-3424" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "1389 Rex Rest", 41, new DateTime(1983, 4, 8, 9, 4, 2, 319, DateTimeKind.Local).AddTicks(1397), "Marcelina.Durgan67@hotmail.com", "Roel", "Male", "Witting", "cieiiaeo", "(243) 678-1115 x5147" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "71450 McLaughlin Burgs", 49, new DateTime(1933, 2, 9, 6, 17, 1, 301, DateTimeKind.Local).AddTicks(1879), "Leon81@hotmail.com", "Rubie", "Female", "Zieme", "raiieaao", "(877) 943-7111" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "8749 Frances Light", 67, new DateTime(1965, 1, 1, 22, 54, 30, 533, DateTimeKind.Local).AddTicks(944), "Kurtis.Carter@hotmail.com", "Florence", "Other", "Nienow", "foiauouo", "1-941-467-2051 x4032" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "7776 Klein Underpass", 90, new DateTime(1939, 4, 24, 16, 11, 41, 858, DateTimeKind.Local).AddTicks(9176), "Sigmund.Emard97@gmail.com", "Bryana", "Larson", "riaooeeo", "(287) 320-9347 x972" });

            migrationBuilder.CreateIndex(
                name: "IX_doctors_specialty_id1",
                table: "doctors",
                column: "specialty_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "specialties");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "106 Frieda Points", 63, new DateTime(1944, 2, 28, 14, 40, 48, 428, DateTimeKind.Local).AddTicks(8205), "Hadley.Schamberger25@yahoo.com", "Mafalda", "Sawayn", "peeaoaoa", "1-349-929-5629 x354" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "697 Fisher Route", 84, new DateTime(1979, 10, 18, 3, 34, 23, 201, DateTimeKind.Local).AddTicks(6530), "Catharine.Feeney81@gmail.com", "Joanie", "Orn", "loioieiu", "1-307-662-7853 x925" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "504 Vincent Glen", 28, new DateTime(1971, 5, 29, 13, 26, 11, 193, DateTimeKind.Local).AddTicks(9013), "Karlie.Romaguera84@gmail.com", "Laney", "Lemke", "qooieeii", "1-637-356-6324" });

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

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "This role is for patients", "Patient" },
                    { 2, "This role is for doctors", "Doctor" }
                });
        }
    }
}
