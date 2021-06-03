﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEIIApp.Server.Data;

namespace SEIIApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210601162332_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEIIApp.Server.Domain.LessonDefinition", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("lessonNumber")
                        .HasColumnType("int");

                    b.Property<string>("lessonTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("lessonNumber")
                        .IsUnique();

                    b.ToTable("LessonDefinitions");
                });

            modelBuilder.Entity("SEIIApp.Server.Domain.MessageDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("receiverId")
                        .HasColumnType("int");

                    b.Property<string>("receiverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("senderId")
                        .HasColumnType("int");

                    b.Property<string>("senderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("unread")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MessageDefinitions");
                });

            modelBuilder.Entity("SEIIApp.Server.Domain.ProfilDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProfilDefinitions");
                });
#pragma warning restore 612, 618
        }
    }
}
