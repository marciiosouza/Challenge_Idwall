﻿// <auto-generated />
using IdWall.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace IdWall.Migrations
{
    [DbContext(typeof(AppDbContext.DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IdWall.Model.SuspeitoModel", b =>
                {
                    b.Property<int>("SuspeitoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("SUSPEITOID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuspeitoId"));

                    b.Property<string>("classificacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CLASSIFICACAO");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NOME");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("SEXO");

                    b.HasKey("SuspeitoId");

                    b.ToTable("Suspeito");
                });

            modelBuilder.Entity("IdWall.Model.UsuarioModel", b =>
                {
                    b.Property<string>("Usuario")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Usuario");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
