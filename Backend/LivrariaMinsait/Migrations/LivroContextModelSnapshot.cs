﻿// <auto-generated />
using System;
using LivrariaMinsait.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LivrariaMinsait.Migrations
{
    [DbContext(typeof(LivroContext))]
    partial class LivroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LivrariaMinsait.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Autor");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DataPublicacao");

                    b.Property<int>("Edicao")
                        .HasMaxLength(2)
                        .HasColumnType("integer")
                        .HasColumnName("Edicao");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Editora");

                    b.Property<int>("QtdePaginas")
                        .HasColumnType("integer")
                        .HasColumnName("QtdePaginas");

                    b.Property<string>("Resumo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("Resumo");

                    b.Property<string>("SubTitulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Subtitulo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });
#pragma warning restore 612, 618
        }
    }
}
