﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VueCineApi.Data;

#nullable disable

namespace VueCineApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240227201925_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VueCineApi.Models.Movie", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Actors = "philipe marcus",
                            Description = "es una película de acción y ciencia ficción dirigida por Jon Turteltaub y estrenada en 2018. La trama gira en torno a un grupo de científicos que deben detener a un megalodón",
                            Director = "Jon turtle",
                            Image = "meg2.jpg",
                            Title = "THE MEG 2"
                        },
                        new
                        {
                            Id = 2,
                            Actors = "Martin Scorsese",
                            Description = "es una película de ciencia ficción española dirigida por Galder Gaztelu-Urrutia, lanzada en 2019. La película se centra en un centro de reclusión vertical donde los prisioneros están dispuestos en celdas apiladas, y una plataforma de comida desciende a través de los niveles, dejando a los prisioneros de los niveles superiores con menos comida.",
                            Director = "Galder Gaztelu-Urrutia",
                            Image = "elhoyo.png",
                            Title = "EL HOYO"
                        },
                        new
                        {
                            Id = 3,
                            Actors = "Leonardo DiCaprio",
                            Description = "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino.",
                            Director = "Martin Scorsese",
                            Image = "mario.png",
                            Title = "SUPER MARIO BROS"
                        },
                        new
                        {
                            Id = 4,
                            Actors = "Meryl Streep",
                            Description = "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'.",
                            Director = "Quentin Tarantino",
                            Image = "granturismo.png",
                            Title = "GRAN TURISMO"
                        },
                        new
                        {
                            Id = 5,
                            Actors = "philipe marcus",
                            Description = "es una película de acción y ciencia ficción dirigida por Jon Turteltaub y estrenada en 2018. La trama gira en torno a un grupo de científicos que deben detener a un megalodón",
                            Director = "Alfred Hitchcock",
                            Image = "meg2.jpg",
                            Title = "THE MEG 2"
                        },
                        new
                        {
                            Id = 6,
                            Actors = "Julia Roberts",
                            Description = "es una película de ciencia ficción española dirigida por Galder Gaztelu-Urrutia, lanzada en 2019. La película se centra en un centro de reclusión vertical donde los prisioneros están dispuestos en celdas apiladas, y una plataforma de comida desciende a través de los niveles, dejando a los prisioneros de los niveles superiores con menos comida.",
                            Director = "Ben Wheatley",
                            Image = "elhoyo.png",
                            Title = "EL HOYO"
                        },
                        new
                        {
                            Id = 7,
                            Actors = "Leonardo DiCaprio",
                            Description = "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino.",
                            Director = "Alfred Hitchcock",
                            Image = "mario.png",
                            Title = "SUPER MARIO BROS"
                        },
                        new
                        {
                            Id = 8,
                            Actors = "Meryl Streep",
                            Description = "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'.",
                            Director = "Quentin Tarantino",
                            Image = "granturismo.png",
                            Title = "GRAN TURISMO"
                        },
                        new
                        {
                            Id = 9,
                            Actors = "Leonardo DiCaprio",
                            Description = "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino.",
                            Director = "Ben Wheatley",
                            Image = "mario.png",
                            Title = "SUPERMARIO BROS"
                        },
                        new
                        {
                            Id = 10,
                            Actors = "Meryl Streep",
                            Description = "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'.",
                            Director = "Quentin Tarantino",
                            Image = "granturismo.png",
                            Title = "GRAN TURISMO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
