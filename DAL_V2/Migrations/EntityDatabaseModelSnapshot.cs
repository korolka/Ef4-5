﻿// <auto-generated />
using System;
using DAL_V2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL_V2.Migrations
{
    [DbContext(typeof(EntityDatabase))]
    partial class EntityDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL_V2.Entity.Cart", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("74455efe-9d9b-4235-ae9c-00d40871acba"),
                            UserId = new Guid("7650d171-d1ce-454d-8561-ae28f65e0f0a")
                        },
                        new
                        {
                            ProductId = new Guid("fb476203-d61a-41d8-b159-ec0e5f679ee6"),
                            UserId = new Guid("7650d171-d1ce-454d-8561-ae28f65e0f0a")
                        },
                        new
                        {
                            ProductId = new Guid("db2db7d9-8837-455a-af64-892deef5386a"),
                            UserId = new Guid("ee42391c-9ee1-4ee4-b803-9ddbe5c20f00")
                        });
                });

            modelBuilder.Entity("DAL_V2.Entity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"),
                            Icon = "favicon.ico",
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("10db6307-3954-4c1d-990e-51a243e559b0"),
                            Icon = "favicon.ico",
                            Name = "Newspaper"
                        },
                        new
                        {
                            Id = new Guid("7d96cbe7-4040-4d53-90ee-da8dab254057"),
                            Icon = "favicon.ico",
                            Name = "Magazine"
                        });
                });

            modelBuilder.Entity("DAL_V2.Entity.KeyParams", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KeyWordId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "KeyWordId");

                    b.HasIndex("KeyWordId");

                    b.ToTable("KeyLink");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("4f2ece48-703e-4e5e-b1b4-c51efe228695"),
                            KeyWordId = new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb")
                        },
                        new
                        {
                            ProductId = new Guid("4f2ece48-703e-4e5e-b1b4-c51efe228695"),
                            KeyWordId = new Guid("0f774494-c364-4d45-9946-96688f9bc57d")
                        },
                        new
                        {
                            ProductId = new Guid("f6f45419-7834-43ca-a53a-318a8abd7887"),
                            KeyWordId = new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb")
                        },
                        new
                        {
                            ProductId = new Guid("f6f45419-7834-43ca-a53a-318a8abd7887"),
                            KeyWordId = new Guid("0f774494-c364-4d45-9946-96688f9bc57d")
                        },
                        new
                        {
                            ProductId = new Guid("f127e7cd-5390-4475-9376-7ac4992d22fa"),
                            KeyWordId = new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb")
                        },
                        new
                        {
                            ProductId = new Guid("f127e7cd-5390-4475-9376-7ac4992d22fa"),
                            KeyWordId = new Guid("0f774494-c364-4d45-9946-96688f9bc57d")
                        },
                        new
                        {
                            ProductId = new Guid("db2db7d9-8837-455a-af64-892deef5386a"),
                            KeyWordId = new Guid("35e5636e-9a5f-459b-bafd-da31b43e46c1")
                        },
                        new
                        {
                            ProductId = new Guid("db2db7d9-8837-455a-af64-892deef5386a"),
                            KeyWordId = new Guid("42f8c413-093d-4e7d-8e5d-7990e7ea75ed")
                        },
                        new
                        {
                            ProductId = new Guid("db2db7d9-8837-455a-af64-892deef5386a"),
                            KeyWordId = new Guid("f74870d3-744f-4c58-a5d7-b442e5022875")
                        },
                        new
                        {
                            ProductId = new Guid("fb476203-d61a-41d8-b159-ec0e5f679ee6"),
                            KeyWordId = new Guid("35e5636e-9a5f-459b-bafd-da31b43e46c1")
                        },
                        new
                        {
                            ProductId = new Guid("74455efe-9d9b-4235-ae9c-00d40871acba"),
                            KeyWordId = new Guid("f74870d3-744f-4c58-a5d7-b442e5022875")
                        },
                        new
                        {
                            ProductId = new Guid("227e013b-3313-4d03-8cbb-c01a0f3cc383"),
                            KeyWordId = new Guid("f74870d3-744f-4c58-a5d7-b442e5022875")
                        });
                });

            modelBuilder.Entity("DAL_V2.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ActionPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionField1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionField2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74455efe-9d9b-4235-ae9c-00d40871acba"),
                            ActionPrice = 1.0,
                            CategoryId = new Guid("10db6307-3954-4c1d-990e-51a243e559b0"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "NY Times",
                            Price = 1.99
                        },
                        new
                        {
                            Id = new Guid("227e013b-3313-4d03-8cbb-c01a0f3cc383"),
                            ActionPrice = 1.0,
                            CategoryId = new Guid("10db6307-3954-4c1d-990e-51a243e559b0"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "Financial times",
                            Price = 2.0
                        },
                        new
                        {
                            Id = new Guid("db2db7d9-8837-455a-af64-892deef5386a"),
                            ActionPrice = 1.0,
                            CategoryId = new Guid("7d96cbe7-4040-4d53-90ee-da8dab254057"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "Spiegel",
                            Price = 1.53
                        },
                        new
                        {
                            Id = new Guid("fb476203-d61a-41d8-b159-ec0e5f679ee6"),
                            ActionPrice = 1.0,
                            CategoryId = new Guid("7d96cbe7-4040-4d53-90ee-da8dab254057"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "Forbes",
                            Price = 1.74
                        },
                        new
                        {
                            Id = new Guid("f127e7cd-5390-4475-9376-7ac4992d22fa"),
                            ActionPrice = 2.8999999999999999,
                            CategoryId = new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "CLR Programming",
                            Price = 5.5
                        },
                        new
                        {
                            Id = new Guid("f6f45419-7834-43ca-a53a-318a8abd7887"),
                            ActionPrice = 2.8999999999999999,
                            CategoryId = new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "Using patterns",
                            Price = 3.2000000000000002
                        },
                        new
                        {
                            Id = new Guid("4f2ece48-703e-4e5e-b1b4-c51efe228695"),
                            ActionPrice = 2.1000000000000001,
                            CategoryId = new Guid("ba704c98-7460-4297-9ada-690d86d4e6f3"),
                            Description = "Lorem ipsum",
                            DescriptionField1 = "Lorem ipsum",
                            DescriptionField2 = "Lorem ipsum",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                            Name = "Java programming",
                            Price = 3.8500000000000001
                        });
                });

            modelBuilder.Entity("DAL_V2.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7650d171-d1ce-454d-8561-ae28f65e0f0a"),
                            Email = "email@gmail.com",
                            Login = "tom1996",
                            Name = "Tom",
                            Password = "strongPassword"
                        },
                        new
                        {
                            Id = new Guid("ee42391c-9ee1-4ee4-b803-9ddbe5c20f00"),
                            Email = "johm.email@gmail.com",
                            Login = "john_5709",
                            Name = "John",
                            Password = "strongPassword2"
                        });
                });

            modelBuilder.Entity("DAL_V2.Entity.Word", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Words");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c6c30edb-ff89-4103-96cb-ca4f3dedfaeb"),
                            Keyword = "book"
                        },
                        new
                        {
                            Id = new Guid("0f774494-c364-4d45-9946-96688f9bc57d"),
                            Keyword = "development"
                        },
                        new
                        {
                            Id = new Guid("f74870d3-744f-4c58-a5d7-b442e5022875"),
                            Keyword = "news"
                        },
                        new
                        {
                            Id = new Guid("42f8c413-093d-4e7d-8e5d-7990e7ea75ed"),
                            Keyword = "spiegel"
                        },
                        new
                        {
                            Id = new Guid("35e5636e-9a5f-459b-bafd-da31b43e46c1"),
                            Keyword = "magazine"
                        });
                });

            modelBuilder.Entity("DAL_V2.Entity.Cart", b =>
                {
                    b.HasOne("DAL_V2.Entity.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL_V2.Entity.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL_V2.Entity.KeyParams", b =>
                {
                    b.HasOne("DAL_V2.Entity.Word", "KeyWord")
                        .WithMany("ProductLinks")
                        .HasForeignKey("KeyWordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL_V2.Entity.Product", "Product")
                        .WithMany("KeyParams")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KeyWord");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL_V2.Entity.Product", b =>
                {
                    b.HasOne("DAL_V2.Entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DAL_V2.Entity.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL_V2.Entity.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("KeyParams");
                });

            modelBuilder.Entity("DAL_V2.Entity.User", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("DAL_V2.Entity.Word", b =>
                {
                    b.Navigation("ProductLinks");
                });
#pragma warning restore 612, 618
        }
    }
}