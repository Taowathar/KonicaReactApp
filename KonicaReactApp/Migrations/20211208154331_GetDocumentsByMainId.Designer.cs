﻿// <auto-generated />
using System;
using KonicaReactApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KonicaReactApp.Migrations
{
    [DbContext(typeof(konicaContext))]
    [Migration("20211208154331_GetDocumentsByMainId")]
    partial class GetDocumentsByMainId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KonicaReactApp.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("extension");

                    b.Property<int>("MainId")
                        .HasColumnType("int")
                        .HasColumnName("main_id");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("source");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("dokumentumok");
                });

            modelBuilder.Entity("KonicaReactApp.Models.Esemeny", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("esemeny");
                });

            modelBuilder.Entity("KonicaReactApp.Models.EventType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("KonicaReactApp.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ClientIpAddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Client_IP_address");

                    b.Property<int?>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("Event_id");

                    b.Property<string>("LoginName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Login_name");

                    b.Property<DateTime?>("LoginTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Login_time");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("KonicaReactApp.Models.Naplo", b =>
                {
                    b.Property<int>("DokumentumId")
                        .HasColumnType("int")
                        .HasColumnName("dokumentum_id");

                    b.Property<int>("EsemenyId")
                        .HasColumnType("int")
                        .HasColumnName("esemeny_id");

                    b.Property<DateTime>("HappenedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("happened_at");

                    b.HasIndex("DokumentumId");

                    b.HasIndex("EsemenyId");

                    b.ToTable("naplo");
                });

            modelBuilder.Entity("KonicaReactApp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Password");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)")
                        .HasColumnName("Salt");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KonicaReactApp.Models.Login", b =>
                {
                    b.HasOne("KonicaReactApp.Models.EventType", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK_Logins_EventTypes");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("KonicaReactApp.Models.Naplo", b =>
                {
                    b.HasOne("KonicaReactApp.Models.Document", "Dokumentum")
                        .WithMany()
                        .HasForeignKey("DokumentumId")
                        .HasConstraintName("FK_naplo_dokumentumok")
                        .IsRequired();

                    b.HasOne("KonicaReactApp.Models.Esemeny", "Esemeny")
                        .WithMany()
                        .HasForeignKey("EsemenyId")
                        .HasConstraintName("FK_naplo_esemeny")
                        .IsRequired();

                    b.Navigation("Dokumentum");

                    b.Navigation("Esemeny");
                });
#pragma warning restore 612, 618
        }
    }
}
