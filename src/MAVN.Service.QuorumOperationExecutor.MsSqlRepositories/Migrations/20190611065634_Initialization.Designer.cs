// ReSharper disable All
// <auto-generated />
using System;
using MAVN.Service.QuorumOperationExecutor.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.QuorumOperationExecutor.MsSqlRepositories.Migrations
{
    [DbContext(typeof(QoeContext))]
    [Migration("20190611065634_Initialization")]
    partial class Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("quorum_operation_executor")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.QuorumOperationExecutor.MsSqlRepositories.Entities.OperationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("TransactionData")
                        .HasColumnName("transaction_data");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash");

                    b.HasKey("Id");

                    b.ToTable("operations");
                });
#pragma warning restore 612, 618
        }
    }
}
