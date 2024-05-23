﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StorageSystem.Models;

#nullable disable

namespace StorageSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ItemStorageBin", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("integer");

                    b.Property<int>("StorageBinsId")
                        .HasColumnType("integer");

                    b.HasKey("ItemsId", "StorageBinsId");

                    b.HasIndex("StorageBinsId");

                    b.ToTable("ItemStorageBin");
                });

            modelBuilder.Entity("StorageSystem.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.ToTable("item");
                });

            modelBuilder.Entity("StorageSystem.Models.ItemStorageBin", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("integer")
                        .HasColumnName("itemId");

                    b.Property<int>("StorageBinId")
                        .HasColumnType("integer")
                        .HasColumnName("binId");

                    b.HasKey("ItemId", "StorageBinId");

                    b.HasIndex("StorageBinId");

                    b.ToTable("item_storagebin");
                });

            modelBuilder.Entity("StorageSystem.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("location");
                });

            modelBuilder.Entity("StorageSystem.Models.StorageBin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LocationId")
                        .HasColumnType("integer")
                        .HasColumnName("locationId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("storagebin");
                });

            modelBuilder.Entity("ItemStorageBin", b =>
                {
                    b.HasOne("StorageSystem.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StorageSystem.Models.StorageBin", null)
                        .WithMany()
                        .HasForeignKey("StorageBinsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StorageSystem.Models.ItemStorageBin", b =>
                {
                    b.HasOne("StorageSystem.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StorageSystem.Models.StorageBin", "StorageBin")
                        .WithMany()
                        .HasForeignKey("StorageBinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("StorageBin");
                });

            modelBuilder.Entity("StorageSystem.Models.StorageBin", b =>
                {
                    b.HasOne("StorageSystem.Models.Location", "Location")
                        .WithMany("StorageBins")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("StorageSystem.Models.Location", b =>
                {
                    b.Navigation("StorageBins");
                });
#pragma warning restore 612, 618
        }
    }
}
