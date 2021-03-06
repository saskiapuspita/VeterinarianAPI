// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VeterinarianAPI.Models;

namespace VeterinarianAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VeterinarianAPI.Models.Appointment", b =>
                {
                    b.Property<int>("idAppointment")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactPerson");

                    b.Property<DateTime>("DateOfAppointment");

                    b.Property<string>("Notes");

                    b.Property<string>("PetName");

                    b.Property<int?>("customeridCustomer");

                    b.HasKey("idAppointment");

                    b.HasIndex("customeridCustomer");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("VeterinarianAPI.Models.Customer", b =>
                {
                    b.Property<int>("idCustomer")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("PostalCode");

                    b.HasKey("idCustomer");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VeterinarianAPI.Models.Appointment", b =>
                {
                    b.HasOne("VeterinarianAPI.Models.Customer", "customer")
                        .WithMany("Appointment")
                        .HasForeignKey("customeridCustomer");
                });
#pragma warning restore 612, 618
        }
    }
}
