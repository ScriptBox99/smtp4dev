﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rnwood.Smtp4dev.Data;
using Rnwood.Smtp4dev.DbModel;

namespace Rnwood.Smtp4dev.Migrations
{
    [DbContext(typeof(Smtp4devDbContext))]
    [Migration("20181020095712_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Data");

                    b.Property<string>("From");

                    b.Property<string>("MimeParseError");

                    b.Property<DateTime>("ReceivedDate");

                    b.Property<string>("Subject");

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientAddress");

                    b.Property<string>("ClientName");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Log");

                    b.Property<int>("NumberOfMessages");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
