using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rol_id = table.Column<int>(type: "int", nullable: false),
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
                    phone_number = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role_id = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    { 1, "523 Reyes Vista", 34, new DateTime(2004, 5, 5, 18, 15, 29, 684, DateTimeKind.Local).AddTicks(2408), "Jeanne.Hudson@yahoo.com", "Terry", "Female", "Bartell", null, null, "tuaeuaua", "1-572-624-9558 x777", 1, null },
                    { 2, "80617 Hauck Gateway", 63, new DateTime(1929, 9, 4, 7, 47, 18, 703, DateTimeKind.Local).AddTicks(8629), "Hildegard85@hotmail.com", "Hoyt", "Male", "Berge", null, null, "joaeeiao", "1-997-766-6888 x3850", 1, null },
                    { 3, "8943 Emiliano Oval", 60, new DateTime(1949, 11, 6, 11, 32, 29, 957, DateTimeKind.Local).AddTicks(6163), "Dixie70@hotmail.com", "Stephania", "Female", "Monahan", null, null, "louoioou", "873-484-9501 x83798", 2, null },
                    { 4, "7535 Flo Road", 67, new DateTime(1949, 9, 25, 16, 25, 45, 794, DateTimeKind.Local).AddTicks(1832), "Randi_Nicolas@gmail.com", "Tyler", "Male", "Macejkovic", null, null, "vaeieieo", "697.983.2219", 2, null },
                    { 5, "265 Mohr Cape", 56, new DateTime(1949, 8, 15, 17, 18, 12, 379, DateTimeKind.Local).AddTicks(5509), "Dameon_Robel@hotmail.com", "Reid", "Male", "Dare", null, null, "hiuioeiu", "848-418-5106 x0072", 1, null },
                    { 6, "38842 O'Keefe Expressway", 22, new DateTime(1986, 1, 27, 17, 48, 44, 366, DateTimeKind.Local).AddTicks(1416), "Mireille_Walker@gmail.com", "Zoe", "Male", "Heaney", null, null, "paiiuuiu", "(916) 238-9400", 1, null },
                    { 7, "674 Araceli Garden", 96, new DateTime(1971, 4, 7, 8, 47, 26, 6, DateTimeKind.Local).AddTicks(7837), "Llewellyn_Jenkins19@hotmail.com", "Hermina", "Other", "Corkery", null, null, "kiuiaaau", "558-732-2413 x709", 1, null },
                    { 8, "0594 Mohr Curve", 20, new DateTime(1977, 2, 22, 15, 10, 11, 140, DateTimeKind.Local).AddTicks(2784), "Tyrique.Dooley3@yahoo.com", "Jenifer", "Male", "Hackett", null, null, "gueuaeuo", "(615) 285-7098 x6235", 2, null },
                    { 9, "425 Rico Ways", 65, new DateTime(1974, 4, 22, 12, 17, 28, 355, DateTimeKind.Local).AddTicks(9519), "Damon_Batz@yahoo.com", "Leatha", "Other", "Beier", null, null, "touiauae", "728-299-6688 x0249", 2, null },
                    { 10, "27737 Brice Shores", 63, new DateTime(1948, 9, 18, 2, 36, 41, 255, DateTimeKind.Local).AddTicks(6995), "Cristobal24@hotmail.com", "Cordie", "Male", "Hayes", null, null, "yooaiaeu", "(546) 959-6142 x2663", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_role_id",
                table: "users",
                column: "role_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
