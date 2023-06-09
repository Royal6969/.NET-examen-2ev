﻿// <auto-generated />
using System;
using DAL.contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(NotaEvaluacionContext))]
    partial class NotaEvaluacionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DAL.models.Entities.Evaluacion", b =>
                {
                    b.Property<string>("Cod_evaluacion")
                        .HasColumnType("text")
                        .HasColumnName("Cod_evaluacion");

                    b.Property<string>("Desc_evaluacion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Desc_evaluacion");

                    b.HasKey("Cod_evaluacion");

                    b.ToTable("eva_cat_evaluacion", "sc_evaluacion");
                });

            modelBuilder.Entity("DAL.models.Entities.Nota", b =>
                {
                    b.Property<int>("Id_nota_evaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id_nota_evaluacion");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id_nota_evaluacion"));

                    b.Property<string>("Cod_alumno")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_alumno");

                    b.Property<string>("Cod_evaluacion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cod_evaluacion");

                    b.Property<DateTime>("Md_fch")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("Md_fch");

                    b.Property<string>("Md_uuid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Md_uuid");

                    b.Property<int>("Nota_evaluacion")
                        .HasColumnType("integer")
                        .HasColumnName("Nota_evaluacion");

                    b.HasKey("Id_nota_evaluacion");

                    b.HasIndex("Cod_evaluacion");

                    b.ToTable("eva_tch_notas_evaluacion", "sc_evaluacion");
                });

            modelBuilder.Entity("DAL.models.Entities.Nota", b =>
                {
                    b.HasOne("DAL.models.Entities.Evaluacion", "Evaluacion")
                        .WithMany("ListaNotas")
                        .HasForeignKey("Cod_evaluacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evaluacion");
                });

            modelBuilder.Entity("DAL.models.Entities.Evaluacion", b =>
                {
                    b.Navigation("ListaNotas");
                });
#pragma warning restore 612, 618
        }
    }
}
