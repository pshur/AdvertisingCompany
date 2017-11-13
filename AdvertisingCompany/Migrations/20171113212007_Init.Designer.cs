﻿// <auto-generated />
using AdvertisingCompany.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AdvertisingCompany.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20171113212007_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvertisingCompany.Models.AdditionalServise", b =>
                {
                    b.Property<int>("AdditionalServiseID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DiscriptionAdditionalServise");

                    b.Property<string>("NameAdditionalServise");

                    b.HasKey("AdditionalServiseID");

                    b.ToTable("AdditionalServises");
                });

            modelBuilder.Entity("AdvertisingCompany.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("NameClient");

                    b.Property<int>("PhoneNumber");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AdvertisingCompany.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdditionalServiseID");

                    b.Property<string>("LocationT");

                    b.Property<string>("NameLocation");

                    b.Property<int>("TypeAdvertisingID");

                    b.HasKey("LocationID");

                    b.HasIndex("AdditionalServiseID");

                    b.HasIndex("TypeAdvertisingID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("AdvertisingCompany.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientID");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("DateOfBegin");

                    b.Property<DateTime>("DateOfEnd");

                    b.Property<int>("LocationID");

                    b.Property<int>("PaymentNote");

                    b.Property<int>("Price");

                    b.Property<int>("ResponsibleOfficerID");

                    b.Property<string>("Servise");

                    b.HasKey("OrderID");

                    b.HasIndex("ClientID");

                    b.HasIndex("LocationID");

                    b.HasIndex("ResponsibleOfficerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AdvertisingCompany.Models.ResponsibleOfficer", b =>
                {
                    b.Property<int>("ResponsibleOfficerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("NameResponsibleOfficer");

                    b.Property<int>("PhoneNumber");

                    b.HasKey("ResponsibleOfficerID");

                    b.ToTable("ResponsibleOfficers");
                });

            modelBuilder.Entity("AdvertisingCompany.Models.TypeAdvertising", b =>
                {
                    b.Property<int>("TypeAdvertisingID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DiscriptionTypeAdvertising");

                    b.Property<string>("NameTypeAdvertising");

                    b.HasKey("TypeAdvertisingID");

                    b.ToTable("TypeAdvertisings");
                });

            modelBuilder.Entity("AdvertisingCompany.Models.Location", b =>
                {
                    b.HasOne("AdvertisingCompany.Models.AdditionalServise", "AdditionalServise")
                        .WithMany("Locations")
                        .HasForeignKey("AdditionalServiseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AdvertisingCompany.Models.TypeAdvertising", "TypeAdvertising")
                        .WithMany("Locations")
                        .HasForeignKey("TypeAdvertisingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdvertisingCompany.Models.Order", b =>
                {
                    b.HasOne("AdvertisingCompany.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AdvertisingCompany.Models.Location")
                        .WithMany("Orders")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AdvertisingCompany.Models.ResponsibleOfficer", "ResponsibleOfficers")
                        .WithMany("Orders")
                        .HasForeignKey("ResponsibleOfficerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
