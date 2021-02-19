﻿// <auto-generated />
using System;
using Darooha.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Darooha.Data.Migrations.MainDataBase
{
    [DbContext(typeof(DaroohaDbContext))]
    [Migration("20210216075036_addBrand")]
    partial class addBrand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Darooha.Data.Models.Notification", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EnterEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("EnterSms")
                        .HasColumnType("bit");

                    b.Property<bool>("EnterTelegram")
                        .HasColumnType("bit");

                    b.Property<bool>("ExitEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("ExitSms")
                        .HasColumnType("bit");

                    b.Property<bool>("ExitTelegram")
                        .HasColumnType("bit");

                    b.Property<bool>("LoginEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("LoginSms")
                        .HasColumnType("bit");

                    b.Property<bool>("LoginTelegram")
                        .HasColumnType("bit");

                    b.Property<bool>("TicketEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("TicketSms")
                        .HasColumnType("bit");

                    b.Property<bool>("TicketTelegram")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Darooha.Data.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Brand", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BrandLogoUrl")
                        .HasColumnType("int");

                    b.Property<int>("BrandName")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Tbl_Brands");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Comment", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CommentPoint")
                        .HasColumnType("int");

                    b.Property<string>("CommentResponse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("commentConfirm")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Tbl_Comments");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_HomeFirstSlider", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ProductId");

                    b.ToTable("Tbl_HomeFirstSlider");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Menu", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("MenuImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subMenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tbl_Menues");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Order", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("PaymentMethod")
                        .HasColumnType("smallint");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Tbl_Orders");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_OrderItem", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Tbl_OrderItems");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Product", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnclosureType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("GenderOfConsumer")
                        .HasColumnType("smallint");

                    b.Property<string>("Indications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSpecial")
                        .HasColumnType("bit");

                    b.Property<string>("Maintenance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturingCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodUse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<string>("ScientificName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SumPoint")
                        .HasColumnType("int");

                    b.Property<string>("Tbl_MenuID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Warnings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Tbl_MenuID");

                    b.ToTable("Tbl_Products");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_ProductImage", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ProductId");

                    b.ToTable("Tbl_ProductImages");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Setting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .HasColumnType("text");

                    b.Property<string>("AppLogo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AppWorkingTime")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CharityName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CloudinaryAPISecret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CloudinaryAPIkey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CloudinaryCloudName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("CommentShowWithConfirm")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("text");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ENamadLogo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool?>("EnableRamesanMessage")
                        .HasColumnType("bit");

                    b.Property<string>("FirstPhone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FromEmail")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("InstagramChannel")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool?>("RamesanCloseOrder")
                        .HasColumnType("bit");

                    b.Property<string>("RamesanMessage")
                        .HasColumnType("text");

                    b.Property<string>("SecendPhone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sender")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SmsPanelPassword")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Smtp")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("StudentDinnerEndTime")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TelegramID")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<bool>("UploadLocal")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Tbl_Settings");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirm")
                        .HasColumnType("bit");

                    b.Property<string>("EmailConfirmCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastOnlineTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MobPhoneConfirm")
                        .HasColumnType("bit");

                    b.Property<string>("MobPhoneConfirmCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NotificationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnlineStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("UserEnableStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_UserAddress", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLatLng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Tbl_UserAddresses");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Wallet", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Tbl_Wallets");
                });

            modelBuilder.Entity("Darooha.Data.Models.Ticket", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<short>("Department")
                        .HasColumnType("smallint");

                    b.Property<bool>("IsAdminSide")
                        .HasColumnType("bit");

                    b.Property<short>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Darooha.Data.Models.TicketContent", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsAdminSide")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("TicketId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketContents");
                });

            modelBuilder.Entity("Darooha.Data.Models.Token", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("Darooha.Data.Models.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Darooha.Data.Models.Notification", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Comment", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_Product", "Tbl_Product")
                        .WithMany("Tbl_Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Darooha.Data.Models.Tbl_User", "Tbl_User")
                        .WithMany("Tbl_Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_HomeFirstSlider", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_Product", "Tbl_Product")
                        .WithMany("Tbl_HomeFirstSlider")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Order", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("Tbl_Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_OrderItem", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_Order", "Tbl_Order")
                        .WithMany("Tbl_OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Darooha.Data.Models.Tbl_Product", "Tbl_Product")
                        .WithMany("Tbl_OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Product", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_Menu", "Tbl_Menu")
                        .WithMany("Tbl_Products")
                        .HasForeignKey("Tbl_MenuID");
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_ProductImage", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_Product", "Tbl_Product")
                        .WithMany("Tbl_ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_UserAddress", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("Tbl_UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Tbl_Wallet", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("Tbl_Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Ticket", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.TicketContent", b =>
                {
                    b.HasOne("Darooha.Data.Models.Ticket", "Ticket")
                        .WithMany("TicketContents")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.Token", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Darooha.Data.Models.UserRole", b =>
                {
                    b.HasOne("Darooha.Data.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Darooha.Data.Models.Tbl_User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Darooha.Data.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Darooha.Data.Models.Tbl_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
