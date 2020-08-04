﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentsLimitInsurance.Infrastructure.Migrations
{
    [DbContext(typeof(ContentsLimitContext))]
    [Migration("20200804023829_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("ContentsLimitInsurance.Data.Entities.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AssetCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DatePurchased")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("AssetCategoryId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a124f35-67fc-4f7a-81bb-4160b2d1af1b"),
                            AssetCategoryId = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Living Room",
                            Name = "TV",
                            Value = 2000.0
                        },
                        new
                        {
                            Id = new Guid("4b576cad-3f93-4a6f-86dd-30c70c748ab6"),
                            AssetCategoryId = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Living Room",
                            Name = "Playstation",
                            Value = 400.0
                        },
                        new
                        {
                            Id = new Guid("e0a6554c-8b98-443e-8d68-a0ecb28c35c5"),
                            AssetCategoryId = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Bedroom",
                            Name = "Stereo",
                            Value = 1600.0
                        },
                        new
                        {
                            Id = new Guid("144343cd-e05d-4dd8-98da-762a38110de9"),
                            AssetCategoryId = new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Bedroom",
                            Name = "Shirts",
                            Value = 1100.0
                        },
                        new
                        {
                            Id = new Guid("a86d0eaf-1deb-42ee-a49c-8e568087de6d"),
                            AssetCategoryId = new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Bedroom",
                            Name = "Jeans",
                            Value = 1100.0
                        },
                        new
                        {
                            Id = new Guid("4d753d18-bc26-4502-8204-bcd6a8694604"),
                            AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Kitchen",
                            Name = "Pots and Pans",
                            Value = 3000.0
                        },
                        new
                        {
                            Id = new Guid("5e888336-cc2d-4a83-b485-6494c39ed31f"),
                            AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Kitchen",
                            Name = "Flatware",
                            Value = 500.0
                        },
                        new
                        {
                            Id = new Guid("aa52d401-5b50-4ef7-8b8b-5a07dfc579a0"),
                            AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Kitchen",
                            Name = "Knife Set",
                            Value = 500.0
                        },
                        new
                        {
                            Id = new Guid("5505dcd8-619e-47cf-ad46-fd6d30a8be8e"),
                            AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"),
                            DatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Location = "Kitchen",
                            Name = "Misc",
                            Value = 1000.0
                        });
                });

            modelBuilder.Entity("ContentsLimitInsurance.Data.Entities.AssetCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AssetCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"),
                            IsDeleted = false,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"),
                            IsDeleted = false,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"),
                            IsDeleted = false,
                            Name = "Kitchen"
                        });
                });

            modelBuilder.Entity("ContentsLimitInsurance.Data.Entities.Asset", b =>
                {
                    b.HasOne("ContentsLimitInsurance.Data.Entities.AssetCategory", "AssetCategory")
                        .WithMany("Assets")
                        .HasForeignKey("AssetCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
