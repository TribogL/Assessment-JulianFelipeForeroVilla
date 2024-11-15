using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableMourner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "mourners",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    age = table.Column<int>(type: "int", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    nationality = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    occupation = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mourners", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "mourners",
                columns: new[] { "id", "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "nationality", "occupation", "password", "phone_number" },
                values: new object[,]
                {
                    { 1, "1645 Ewell Hill", 85, new DateTime(1992, 1, 1, 17, 31, 51, 373, DateTimeKind.Local).AddTicks(5907), "Buck.Klein70@hotmail.com", "Lupe", "Other", "Hermiston", null, null, "doeoiaai", "(361) 474-1501 x267" },
                    { 2, "4459 Kiara Walk", 32, new DateTime(1940, 8, 25, 17, 21, 25, 81, DateTimeKind.Local).AddTicks(3377), "Eldridge29@hotmail.com", "Eliane", "Other", "Boyle", null, null, "veooeaoe", "413.816.2343 x2720" },
                    { 3, "6787 Kathlyn Meadows", 35, new DateTime(2005, 2, 24, 19, 7, 39, 335, DateTimeKind.Local).AddTicks(5986), "Burdette.McKenzie76@hotmail.com", "Demario", "Female", "Shanahan", null, null, "taaaouoa", "980-798-4443" },
                    { 4, "4347 Muller Parkway", 18, new DateTime(1976, 10, 13, 0, 16, 36, 549, DateTimeKind.Local).AddTicks(9073), "Merle_Mohr67@gmail.com", "Margarita", "Other", "Stanton", null, null, "vaaoaeie", "450-551-8694 x755" },
                    { 5, "1502 Brooks Gateway", 54, new DateTime(1974, 3, 24, 13, 45, 28, 760, DateTimeKind.Local).AddTicks(4401), "Aileen6@hotmail.com", "Alvina", "Female", "Dietrich", null, null, "baueiuoi", "225.418.8380" },
                    { 6, "624 Larue Inlet", 96, new DateTime(1980, 11, 28, 16, 59, 43, 896, DateTimeKind.Local).AddTicks(5566), "Katherine_Huels@yahoo.com", "Kolby", "Male", "Nader", null, null, "faieoeae", "221.656.2079 x90863" },
                    { 7, "41761 Zachariah Brook", 56, new DateTime(1967, 5, 31, 4, 57, 48, 774, DateTimeKind.Local).AddTicks(7263), "Cordell16@gmail.com", "Mollie", "Male", "Becker", null, null, "qoaouooo", "818.708.7437 x2453" },
                    { 8, "19845 Johnson Greens", 22, new DateTime(1980, 2, 25, 14, 14, 28, 950, DateTimeKind.Local).AddTicks(5097), "Opal.Beier@gmail.com", "Jarrett", "Other", "Deckow", null, null, "soeuauui", "693.217.1420 x451" },
                    { 9, "10124 Block Drive", 66, new DateTime(1953, 11, 19, 20, 38, 8, 637, DateTimeKind.Local).AddTicks(3216), "Kayleigh.Kutch50@hotmail.com", "Ross", "Female", "Bosco", null, null, "qauueeea", "(810) 788-3349 x570" },
                    { 10, "58643 Borer Lights", 82, new DateTime(1957, 8, 9, 20, 2, 45, 819, DateTimeKind.Local).AddTicks(4901), "Howard.Kihn@gmail.com", "Roderick", "Other", "Johnson", null, null, "cieuiaee", "871-547-6164" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mourners");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    role_id = table.Column<int>(type: "int", nullable: true),
                    address = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    age = table.Column<int>(type: "int", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nationality = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    occupation = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rol_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "nationality", "occupation", "Password", "phone_number", "rol_id", "role_id" },
                values: new object[,]
                {
                    { 1, "47152 Labadie Fort", 91, new DateTime(1972, 8, 6, 15, 2, 47, 874, DateTimeKind.Local).AddTicks(8099), "Celine15@gmail.com", "Lera", "Male", "Gottlieb", null, null, "nieouauo", "614-247-2021", 1, null },
                    { 2, "57909 Rempel Shoals", 53, new DateTime(1954, 2, 23, 2, 25, 1, 478, DateTimeKind.Local).AddTicks(5165), "Nicholaus92@hotmail.com", "Sean", "Male", "Murazik", null, null, "soeeaeao", "450.706.0421", 2, null },
                    { 3, "09524 Joelle Ridge", 85, new DateTime(2002, 7, 8, 17, 35, 46, 862, DateTimeKind.Local).AddTicks(1055), "Sally8@gmail.com", "Myrtle", "Female", "Wyman", null, null, "poieaouo", "(656) 873-5819", 1, null },
                    { 4, "0785 Daron Divide", 71, new DateTime(1989, 8, 24, 5, 45, 32, 251, DateTimeKind.Local).AddTicks(973), "Cara.Waters@hotmail.com", "Ramiro", "Female", "Kub", null, null, "woieooea", "581-532-7648 x60036", 1, null },
                    { 5, "17609 Oscar Coves", 49, new DateTime(1947, 1, 25, 15, 23, 45, 972, DateTimeKind.Local).AddTicks(3251), "Tyshawn_Lebsack@yahoo.com", "Olga", "Male", "Steuber", null, null, "fuiioauo", "534.984.0426", 2, null },
                    { 6, "1531 Prosacco Mountains", 99, new DateTime(2002, 11, 25, 2, 20, 48, 118, DateTimeKind.Local).AddTicks(7164), "Jaime.Nicolas26@yahoo.com", "Finn", "Female", "Feeney", null, null, "neiieiie", "616.703.8000 x5185", 2, null },
                    { 7, "4121 Stokes Hill", 62, new DateTime(2006, 8, 11, 7, 38, 49, 34, DateTimeKind.Local).AddTicks(8199), "Felipa_Quitzon32@gmail.com", "Annabel", "Other", "Purdy", null, null, "seieuaiu", "954-771-1529", 2, null },
                    { 8, "74860 Hamill Trace", 25, new DateTime(1994, 6, 10, 14, 30, 59, 178, DateTimeKind.Local).AddTicks(4357), "Noemi98@yahoo.com", "Cristina", "Female", "Prohaska", null, null, "kauaoeoa", "256-776-1882", 2, null },
                    { 9, "48656 Constantin Flat", 38, new DateTime(1979, 2, 4, 23, 3, 10, 915, DateTimeKind.Local).AddTicks(4901), "Narciso_Schoen55@yahoo.com", "Kenya", "Female", "Satterfield", null, null, "tieiuoee", "838-485-0715 x9351", 2, null },
                    { 10, "75073 Gregory Drive", 64, new DateTime(1954, 8, 31, 5, 44, 18, 379, DateTimeKind.Local).AddTicks(5812), "Davon78@hotmail.com", "Josiah", "Female", "Boyer", null, null, "souiuuou", "647-775-3608", 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_role_id",
                table: "users",
                column: "role_id");
        }
    }
}
