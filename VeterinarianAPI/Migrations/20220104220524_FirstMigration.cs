using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeterinarianAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    idCustomer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.idCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    idAppointment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfAppointment = table.Column<DateTime>(nullable: false),
                    PetName = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    customeridCustomer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.idAppointment);
                    table.ForeignKey(
                        name: "FK_Appointment_Customer_customeridCustomer",
                        column: x => x.customeridCustomer,
                        principalTable: "Customer",
                        principalColumn: "idCustomer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_customeridCustomer",
                table: "Appointment",
                column: "customeridCustomer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
