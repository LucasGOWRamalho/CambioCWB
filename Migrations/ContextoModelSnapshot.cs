﻿// <auto-generated />
using System;
using ComoFazerCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComoFazerCrud.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ComoFazerCrud.Models.Servicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeEntrega")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Data de entrega");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext")
                        .HasColumnName("Modelo");

                    b.Property<string>("Ordem")
                        .HasColumnType("longtext")
                        .HasColumnName("Ordem");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Pago");

                    b.Property<float>("Valor")
                        .HasColumnType("float")
                        .HasColumnName("Valor");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
