﻿// <auto-generated />
using System;
using LancheBom.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LancheBom.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221025171650_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LancheBom.Domain.Models.Adicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Adicionais");
                });

            modelBuilder.Entity("LancheBom.Domain.Models.Lanche", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Lanches");
                });

            modelBuilder.Entity("LancheBom.Domain.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LancheId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("LancheId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("LancheBom.Domain.Models.Adicional", b =>
                {
                    b.HasOne("LancheBom.Domain.Models.Pedido", null)
                        .WithMany("Adicionais")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("LancheBom.Domain.Models.Pedido", b =>
                {
                    b.HasOne("LancheBom.Domain.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");
                });

            modelBuilder.Entity("LancheBom.Domain.Models.Pedido", b =>
                {
                    b.Navigation("Adicionais");
                });
#pragma warning restore 612, 618
        }
    }
}