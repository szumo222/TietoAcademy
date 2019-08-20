﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TietoAcademyDemo.Persistence;

namespace TietoAcademyDemo.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20190820105605_PublisherAdd")]
    partial class PublisherAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TietoAcademyDemo.Domain.Book", b =>
                {
                    b.Property<string>("isbn")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("coverUrl");

                    b.Property<int>("numberOfPages");

                    b.Property<DateTime?>("publishDate");

                    b.Property<string>("publishPlace");

                    b.Property<string>("publisher");

                    b.Property<string>("subject");

                    b.Property<string>("title");

                    b.HasKey("isbn");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
