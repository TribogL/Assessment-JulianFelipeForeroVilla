using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specialties_specialty_id1",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_specialty_id1",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "specialty_id1",
                table: "doctors");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "doctors",
                newName: "status");

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "email", "first_name", "gender", "last_name", "office", "password", "specialty_id", "status" },
                values: new object[,]
                {
                    { 1, "Trycia.Stark@gmail.com", "Gage", "Other", "Welch", 170, "kaiueoua", 3, "Moen - Mann" },
                    { 2, "Malachi_Bechtelar50@yahoo.com", "Kristy", "Female", "Hand", 28, "tooiuueu", 9, "Green - Yost" },
                    { 3, "Quentin_Blanda@gmail.com", "Viva", "Other", "Jerde", 222, "quueuaai", 2, "Kozey, Carter and Fadel" },
                    { 4, "Tessie.Konopelski@hotmail.com", "Ludie", "Other", "Bernhard", 109, "cauiaiae", 1, "Jacobson - Rosenbaum" },
                    { 5, "Ben27@yahoo.com", "Jazmyn", "Female", "Torp", 171, "jaoauiee", 3, "Kuvalis - Koss" },
                    { 6, "Isom.Kuhlman@yahoo.com", "Tyra", "Female", "Stanton", 287, "sueuooae", 11, "Leuschke, Hahn and Lindgren" },
                    { 7, "Morgan_Gleichner@yahoo.com", "Heidi", "Male", "Stoltenberg", 194, "ceooeeoa", 11, "Runte, Raynor and Lesch" },
                    { 8, "Sanford20@hotmail.com", "Chaya", "Male", "Quigley", 236, "nueaaoii", 15, "Reilly LLC" },
                    { 9, "Nicolas.Casper20@hotmail.com", "Grover", "Other", "Stroman", 237, "tiuaaaie", 9, "Cummerata LLC" },
                    { 10, "Kamryn.Heidenreich58@yahoo.com", "Nicolette", "Other", "Adams", 161, "geaueoua", 7, "Dietrich - Brown" }
                });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "1912 Linwood Highway", 83, new DateTime(1928, 8, 29, 1, 1, 38, 89, DateTimeKind.Local).AddTicks(6829), "Ryder.Larkin88@hotmail.com", "Moises", "Wisoky", "yuoueeae", "(366) 882-7392 x252" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "5188 Edwardo Shore", 31, new DateTime(1992, 3, 4, 3, 37, 9, 504, DateTimeKind.Local).AddTicks(9919), "Quincy.Cole@gmail.com", "Eino", "Other", "Berge", "wiuaeuau", "382.516.8130" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "0262 Hoppe Via", 50, new DateTime(1940, 2, 7, 6, 3, 29, 69, DateTimeKind.Local).AddTicks(6588), "Nikita18@yahoo.com", "Madyson", "McKenzie", "xeouuoiu", "841.304.4682 x4503" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "82864 Graham Glen", 81, new DateTime(1968, 8, 13, 21, 29, 49, 905, DateTimeKind.Local).AddTicks(6795), "Eudora_Kling@hotmail.com", "Seth", "Other", "Emard", "seaiuiuo", "1-759-768-2157" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "95215 Brown Lane", 72, new DateTime(1975, 4, 6, 7, 42, 11, 645, DateTimeKind.Local).AddTicks(4728), "Hubert20@gmail.com", "Floyd", "Male", "Runolfsdottir", "geiauaau", "273.537.0041" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "166 Antoinette Branch", 24, new DateTime(1978, 2, 3, 20, 18, 32, 735, DateTimeKind.Local).AddTicks(2312), "Alison_Stoltenberg9@yahoo.com", "Reina", "Male", "Nikolaus", "jueaiiei", "944.762.9623" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "42893 Ona Loaf", 55, new DateTime(1929, 11, 20, 9, 49, 55, 789, DateTimeKind.Local).AddTicks(9251), "Clint67@hotmail.com", "Sylvia", "Hermiston", "suaieiea", "(835) 816-2398 x781" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "14302 Pollich Inlet", 32, new DateTime(1933, 5, 14, 23, 50, 2, 192, DateTimeKind.Local).AddTicks(7591), "Roberta17@gmail.com", "Philip", "Other", "Conroy", "roaaaoie", "590.631.8052 x078" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "08835 Stella Stream", 49, new DateTime(1985, 2, 28, 21, 17, 49, 231, DateTimeKind.Local).AddTicks(5443), "Alfredo_Olson94@yahoo.com", "Brain", "Male", "Schimmel", "yiuaoiae", "1-796-234-0346 x685" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "28055 Kuhn Creek", 48, new DateTime(1975, 2, 26, 12, 32, 31, 249, DateTimeKind.Local).AddTicks(6584), "Gregoria_Koelpin@hotmail.com", "Ena", "Male", "Jacobi", "wuaoeaai", "962.684.3215" });

            migrationBuilder.CreateIndex(
                name: "IX_doctors_specialty_id",
                table: "doctors",
                column: "specialty_id");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_specialties_specialty_id",
                table: "doctors",
                column: "specialty_id",
                principalTable: "specialties",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_specialties_specialty_id",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_specialty_id",
                table: "doctors");

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

            migrationBuilder.RenameColumn(
                name: "status",
                table: "doctors",
                newName: "Status");

            migrationBuilder.AddColumn<int>(
                name: "specialty_id1",
                table: "doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "63453 Dashawn Plains", 41, new DateTime(1989, 5, 25, 22, 44, 46, 194, DateTimeKind.Local).AddTicks(7341), "Jerrod57@gmail.com", "Adriel", "Ryan", "duoaaeau", "631.955.1600" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "45816 Destinee Throughway", 90, new DateTime(1978, 6, 16, 16, 29, 31, 711, DateTimeKind.Local).AddTicks(8161), "Walker_Hartmann@gmail.com", "Marlene", "Female", "Weissnat", "xeieoaae", "511.669.2941 x578" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "763 Murl Landing", 26, new DateTime(1975, 7, 27, 18, 46, 54, 291, DateTimeKind.Local).AddTicks(2025), "Derick.Rolfson@gmail.com", "Alexandria", "Bogisich", "xeauieao", "1-424-918-7634 x646" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "1039 Janet Plaza", 95, new DateTime(1991, 10, 12, 0, 25, 5, 612, DateTimeKind.Local).AddTicks(32), "Hilton_Doyle@hotmail.com", "Mitchel", "Male", "Paucek", "geauaaoa", "236.422.1539" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "3534 Vicenta Stream", 69, new DateTime(1930, 8, 12, 12, 16, 37, 463, DateTimeKind.Local).AddTicks(9308), "Shaniya14@hotmail.com", "Reginald", "Other", "Anderson", "siaauuuu", "539-947-4563" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "28081 Wisozk Pine", 85, new DateTime(1957, 4, 7, 7, 17, 24, 24, DateTimeKind.Local).AddTicks(2542), "Lura.Roob0@gmail.com", "Adonis", "Female", "Donnelly", "joauoeeo", "(752) 375-2439 x6876" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "4580 Heidenreich Springs", 82, new DateTime(2002, 4, 13, 22, 15, 22, 159, DateTimeKind.Local).AddTicks(1079), "Marcellus_Runolfsdottir85@hotmail.com", "Britney", "Hintz", "jooaoooo", "1-454-343-8873 x83261" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "5584 Marge Springs", 68, new DateTime(1946, 7, 5, 9, 36, 54, 532, DateTimeKind.Local).AddTicks(6407), "Frederik79@gmail.com", "Beulah", "Male", "Rippin", "suieoiea", "(539) 527-8617" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "53462 Harber Inlet", 94, new DateTime(2006, 3, 21, 11, 30, 14, 529, DateTimeKind.Local).AddTicks(190), "Vesta_Reynolds16@yahoo.com", "Eden", "Other", "Nitzsche", "beioauoa", "450-860-7485" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "4366 Grant Road", 23, new DateTime(1989, 8, 19, 3, 38, 14, 98, DateTimeKind.Local).AddTicks(8605), "Abelardo.MacGyver@hotmail.com", "Dolores", "Other", "Dietrich", "vaiooaia", "908.997.3370" });

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
    }
}
