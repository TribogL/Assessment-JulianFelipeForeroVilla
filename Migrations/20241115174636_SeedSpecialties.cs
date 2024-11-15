using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedSpecialties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "63453 Dashawn Plains", 41, new DateTime(1989, 5, 25, 22, 44, 46, 194, DateTimeKind.Local).AddTicks(7341), "Jerrod57@gmail.com", "Adriel", "Other", "Ryan", "duoaaeau", "631.955.1600" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "763 Murl Landing", 26, new DateTime(1975, 7, 27, 18, 46, 54, 291, DateTimeKind.Local).AddTicks(2025), "Derick.Rolfson@gmail.com", "Alexandria", "Male", "Bogisich", "xeauieao", "1-424-918-7634 x646" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "3534 Vicenta Stream", 69, new DateTime(1930, 8, 12, 12, 16, 37, 463, DateTimeKind.Local).AddTicks(9308), "Shaniya14@hotmail.com", "Reginald", "Anderson", "siaauuuu", "539-947-4563" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "28081 Wisozk Pine", 85, new DateTime(1957, 4, 7, 7, 17, 24, 24, DateTimeKind.Local).AddTicks(2542), "Lura.Roob0@gmail.com", "Adonis", "Donnelly", "joauoeeo", "(752) 375-2439 x6876" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "4580 Heidenreich Springs", 82, new DateTime(2002, 4, 13, 22, 15, 22, 159, DateTimeKind.Local).AddTicks(1079), "Marcellus_Runolfsdottir85@hotmail.com", "Britney", "Female", "Hintz", "jooaoooo", "1-454-343-8873 x83261" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "53462 Harber Inlet", 94, new DateTime(2006, 3, 21, 11, 30, 14, 529, DateTimeKind.Local).AddTicks(190), "Vesta_Reynolds16@yahoo.com", "Eden", "Nitzsche", "beioauoa", "450-860-7485" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "4366 Grant Road", 23, new DateTime(1989, 8, 19, 3, 38, 14, 98, DateTimeKind.Local).AddTicks(8605), "Abelardo.MacGyver@hotmail.com", "Dolores", "Dietrich", "vaiooaia", "908.997.3370" });

            migrationBuilder.InsertData(
                table: "specialties",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Specialty focused on heart health and diseases", "Cardiology" },
                    { 2, "Specialty dealing with disorders of the nervous system", "Neurology" },
                    { 3, "Specialty for children's health and diseases", "Pediatrics" },
                    { 4, "Specialty for skin, hair, and nail conditions", "Dermatology" },
                    { 5, "Specialty for the musculoskeletal system", "Orthopedics" },
                    { 6, "Specialty for cancer diagnosis and treatment", "Oncology" },
                    { 7, "Specialty for mental health disorders and treatments", "Psychiatry" },
                    { 8, "Specialty for female reproductive health", "Gynecology" },
                    { 9, "Specialty for eye health and vision disorders", "Ophthalmology" },
                    { 10, "Specialty focused on anesthesia and perioperative care", "Anesthesiology" },
                    { 11, "Specialty for hormonal disorders and diseases", "Endocrinology" },
                    { 12, "Specialty for digestive system disorders", "Gastroenterology" },
                    { 13, "Specialty for urinary tract and male reproductive system", "Urology" },
                    { 14, "Specialty for lung and respiratory system disorders", "Pulmonology" },
                    { 15, "Specialty for autoimmune and musculoskeletal diseases", "Rheumatology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "id",
                keyValue: 15);

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "gender", "last_name", "password", "phone_number" },
                values: new object[] { "677 Estevan Roads", 88, new DateTime(1957, 6, 29, 8, 31, 22, 885, DateTimeKind.Local).AddTicks(2765), "Maggie.Wisoky@gmail.com", "Dorthy", "Female", "Hilll", "paauuiao", "986-291-3715 x25989" });

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
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "8749 Frances Light", 67, new DateTime(1965, 1, 1, 22, 54, 30, 533, DateTimeKind.Local).AddTicks(944), "Kurtis.Carter@hotmail.com", "Florence", "Nienow", "foiauouo", "1-941-467-2051 x4032" });

            migrationBuilder.UpdateData(
                table: "mourners",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "address", "age", "date_of_birth", "email", "first_name", "last_name", "password", "phone_number" },
                values: new object[] { "7776 Klein Underpass", 90, new DateTime(1939, 4, 24, 16, 11, 41, 858, DateTimeKind.Local).AddTicks(9176), "Sigmund.Emard97@gmail.com", "Bryana", "Larson", "riaooeeo", "(287) 320-9347 x972" });
        }
    }
}
