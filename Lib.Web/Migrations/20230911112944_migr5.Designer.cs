﻿// <auto-generated />
using System;
using Lib.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lib.Web.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230911112944_migr5")]
    partial class migr5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lib.Web.Models.BaseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("BaseModel", (string)null);

                    b.HasDiscriminator<string>("ItemType").HasValue("BaseModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Lib.Web.Models.Book", b =>
                {
                    b.HasBaseType("Lib.Web.Models.BaseModel");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Exemplaire")
                        .HasColumnType("integer");

                    b.Property<int>("ImprintId")
                        .HasColumnType("integer");

                    b.Property<int?>("ImprintId1")
                        .HasColumnType("integer");

                    b.Property<int>("ImprinterId")
                        .HasColumnType("integer");

                    b.Property<int>("LibraryId")
                        .HasColumnType("integer");

                    b.Property<int>("Numpage")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("ImprintId");

                    b.HasIndex("ImprintId1")
                        .IsUnique();

                    b.HasIndex("ImprinterId");

                    b.HasIndex("LibraryId");

                    b.HasDiscriminator().HasValue("Book");
                });

            modelBuilder.Entity("Lib.Web.Models.Imprint", b =>
                {
                    b.HasBaseType("Lib.Web.Models.BaseModel");

                    b.Property<DateTime>("ImprintDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LibraryId")
                        .HasColumnType("integer");

                    b.Property<bool>("RemisOuPas")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("RemiseDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasIndex("LibraryId");

                    b.ToTable("BaseModel", t =>
                        {
                            t.Property("LibraryId")
                                .HasColumnName("Imprint_LibraryId");
                        });

                    b.HasDiscriminator().HasValue("Imprint");
                });

            modelBuilder.Entity("Lib.Web.Models.Imprinter", b =>
                {
                    b.HasBaseType("Lib.Web.Models.BaseModel");

                    b.Property<DateTime>("DatedeNaissance")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Displayname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ImprintId")
                        .HasColumnType("integer");

                    b.Property<int?>("ImprintId1")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LibraryId")
                        .HasColumnType("integer");

                    b.Property<string>("Profil")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("ImprintId");

                    b.HasIndex("ImprintId1")
                        .IsUnique();

                    b.HasIndex("LibraryId");

                    b.ToTable("BaseModel", t =>
                        {
                            t.Property("ImprintId")
                                .HasColumnName("Imprinter_ImprintId");

                            t.Property("ImprintId1")
                                .HasColumnName("Imprinter_ImprintId1");

                            t.Property("LibraryId")
                                .HasColumnName("Imprinter_LibraryId");
                        });

                    b.HasDiscriminator().HasValue("Imprinter");
                });

            modelBuilder.Entity("Lib.Web.Models.Library", b =>
                {
                    b.HasBaseType("Lib.Web.Models.BaseModel");

                    b.HasDiscriminator().HasValue("Library");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lib.Web.Models.Book", b =>
                {
                    b.HasOne("Lib.Web.Models.Imprint", "Imprint")
                        .WithMany("Books")
                        .HasForeignKey("ImprintId");

                    b.HasOne("Lib.Web.Models.Imprint", null)
                        .WithOne("Book")
                        .HasForeignKey("Lib.Web.Models.Book", "ImprintId1");

                    b.HasOne("Lib.Web.Models.Imprinter", "Imprinter")
                        .WithMany("ListBoookImprinter")
                        .HasForeignKey("ImprinterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.Web.Models.Library", "Library")
                        .WithMany("ListBooks")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imprint");

                    b.Navigation("Imprinter");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("Lib.Web.Models.Imprint", b =>
                {
                    b.HasOne("Lib.Web.Models.Library", "Library")
                        .WithMany()
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");
                });

            modelBuilder.Entity("Lib.Web.Models.Imprinter", b =>
                {
                    b.HasOne("Lib.Web.Models.Imprint", "Imprint")
                        .WithMany("Imprinters")
                        .HasForeignKey("ImprintId");

                    b.HasOne("Lib.Web.Models.Imprint", null)
                        .WithOne("Emprinteur")
                        .HasForeignKey("Lib.Web.Models.Imprinter", "ImprintId1");

                    b.HasOne("Lib.Web.Models.Library", "Library")
                        .WithMany("ListImprinters")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imprint");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("Lib.Web.Models.Imprint", b =>
                {
                    b.Navigation("Book")
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Emprinteur")
                        .IsRequired();

                    b.Navigation("Imprinters");
                });

            modelBuilder.Entity("Lib.Web.Models.Imprinter", b =>
                {
                    b.Navigation("ListBoookImprinter");
                });

            modelBuilder.Entity("Lib.Web.Models.Library", b =>
                {
                    b.Navigation("ListBooks");

                    b.Navigation("ListImprinters");
                });
#pragma warning restore 612, 618
        }
    }
}
