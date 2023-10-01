﻿// <auto-generated />
using IdWall.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Idwall.Migrations
{
    [DbContext(typeof(AppDbContext.DataBaseContext))]
    [Migration("20231001033117_hsuhdsaj")]
    partial class hsuhdsaj
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IdWall.Model.SuspeitoModel", b =>
                {
                    b.Property<string>("uid")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("sex")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("uid");

                    b.ToTable("Suspeito");
                });

            modelBuilder.Entity("IdWall.Model.UsuarioModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Email");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Idwall.Model.DataNascimentoSuspeitoModel", b =>
                {
                    b.Property<string>("uid")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("dates_of_birth_used")
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnOrder(1);

                    b.HasKey("uid", "dates_of_birth_used");

                    b.ToTable("DataNascimentoSuspeito");
                });

            modelBuilder.Entity("Idwall.Model.DataNascimentoSuspeitoModel", b =>
                {
                    b.HasOne("IdWall.Model.SuspeitoModel", "Suspeito")
                        .WithMany("dates_of_birth_used")
                        .HasForeignKey("uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suspeito");
                });

            modelBuilder.Entity("IdWall.Model.SuspeitoModel", b =>
                {
                    b.Navigation("dates_of_birth_used");
                });
#pragma warning restore 612, 618
        }
    }
}
