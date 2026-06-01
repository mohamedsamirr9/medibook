using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediBook.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ImageUrl", "Name", "Specialty" },
                values: new object[,]
                {
                    { 1, "https://images.unsplash.com/photo-1622253692010-333f2da6031d?q=80&w=200&auto=format&fit=crop", "Dr. Ahmed Ali", "Cardiology" },
                    { 2, "https://images.unsplash.com/photo-1594824813573-246434e33963?q=80&w=200&auto=format&fit=crop", "Dr. Sara Mohamed", "Cardiology" },
                    { 3, "https://images.unsplash.com/photo-1537368910025-700350fe46c7?q=80&w=200&auto=format&fit=crop", "Dr. Mohamed Hassan", "Dermatology" },
                    { 4, "https://images.unsplash.com/photo-1651008376811-b90baee60c1f?q=80&w=200&auto=format&fit=crop", "Dr. Nour Ahmed", "Dermatology" },
                    { 5, "https://images.unsplash.com/photo-1612349317150-e413f6a5b16d?q=80&w=200&auto=format&fit=crop", "Dr. Omar Khaled", "Pediatrics" },
                    { 6, "https://images.unsplash.com/photo-1559839734-2b71ea197ec2?q=80&w=200&auto=format&fit=crop", "Dr. Mona Said", "Pediatrics" },
                    { 7, "https://images.unsplash.com/photo-1637059824899-a441006a6875?q=80&w=200&auto=format&fit=crop", "Dr. Khaled Ibrahim", "Orthopedics" },
                    { 8, "https://images.unsplash.com/photo-1594824813573-246434e33963?q=80&w=200&auto=format&fit=crop", "Dr. Dina Mostafa", "Orthopedics" },
                    { 9, "https://images.unsplash.com/photo-1622253692010-333f2da6031d?q=80&w=200&auto=format&fit=crop", "Dr. Youssef Adel", "Neurology" },
                    { 10, "https://images.unsplash.com/photo-1651008376811-b90baee60c1f?q=80&w=200&auto=format&fit=crop", "Dr. Rana Tarek", "Neurology" },
                    { 11, "https://images.unsplash.com/photo-1537368910025-700350fe46c7?q=80&w=200&auto=format&fit=crop", "Dr. Hossam Nabil", "General" },
                    { 12, "https://images.unsplash.com/photo-1559839734-2b71ea197ec2?q=80&w=200&auto=format&fit=crop", "Dr. Layla Hassan", "General" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
