﻿// <auto-generated />
using System;
using CPW221_PokemonAdoptionCenter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240718194831_Flabebe")]
    partial class Flabebe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CPW221_PokemonAdoptionCenter.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BattleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageOfPokemon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PokemonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 307,
                            BattleType = "Poison/Ghost",
                            Description = "Super sweet and a bit shy. Molla was found still in her ball after her owner had passed away, and now hopes to find a new playmate. She enjoys night walks and hide-and-seek",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Molla",
                            PokemonType = "Haunter"
                        },
                        new
                        {
                            Id = 2,
                            Age = 4,
                            BattleType = "Poison/Ground",
                            Description = "Coming all the way from the Paldea region, Kinito has a naturally upbeat personality. Kinito enjoys swimming, splashing in puddles, and long afternoon naps.",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Kinito",
                            PokemonType = "Paldean Wooper"
                        },
                        new
                        {
                            Id = 3,
                            Age = 7,
                            BattleType = "Fairy",
                            Description = "Apollo was dropped off at our center by his owner who was 'displeased' about Apollo's evolutionary choices. Nevertheless, Apollo continues to be incredibly affectionate and loving.",
                            ImageOfPokemon = "/images/ICY-Apollo(Sylveon).jpg",
                            IsAvailable = true,
                            Name = "Apollo",
                            PokemonType = "Sylveon (Shiny)"
                        },
                        new
                        {
                            Id = 4,
                            Age = 10,
                            BattleType = "Steel",
                            Description = "This Pokémon has been chosen! Best of luck, buddy!",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = false,
                            Name = "Captain Sushi",
                            PokemonType = "Galarian Meowth"
                        },
                        new
                        {
                            Id = 5,
                            Age = 8,
                            BattleType = "Fairy/Water",
                            Description = "Cleo is one of the most bubbly Pokémon we've ever met (both figuratively and literally) She was dropped off by her previous owner who could no longer care for her.",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Cleo",
                            PokemonType = "Azumarill"
                        },
                        new
                        {
                            Id = 6,
                            Age = 5,
                            BattleType = "Poison/Water",
                            Description = "Found tangled in beach debris. When she refused to return to the sea, she was brought to us to find a home. Chompee is incredibly affectionate and adores physical contact. Just watch out for those spikes, as they may hurt.",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Chompee",
                            PokemonType = "Mareanie"
                        },
                        new
                        {
                            Id = 7,
                            Age = 13,
                            BattleType = "Grass",
                            Description = "This Pokémon has been chosen! Best of luck, buddy!",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = false,
                            Name = "Oliver",
                            PokemonType = "Carnivine"
                        },
                        new
                        {
                            Id = 8,
                            Age = 3,
                            BattleType = "Grass",
                            Description = "This Pokémon has been chosen! Best of luck, buddy!",
                            ImageOfPokemon = "/images/ICY-Lilo(Flababe).jpg",
                            IsAvailable = false,
                            Name = "Lilo",
                            PokemonType = "Flabébé"
                        },
                        new
                        {
                            Id = 9,
                            Age = 9,
                            BattleType = "Water",
                            Description = "Crystal spends most of his time in the pond behind our center, most often dozing or floating in circles. He will occasionally leave the pond to spend time with other Pokémon, but he most often prefers to loaf around. If you're looking for a good couch companion, this is your guy!",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Crystal",
                            PokemonType = "Vaporeon"
                        },
                        new
                        {
                            Id = 10,
                            Age = 102,
                            BattleType = "Grass/Ghost",
                            Description = "Found in an abandoned house, Theodore was brought into our care after it was determined he could not provide for himself in the wild. While he may seem incredibly shy and closed off at first, Theodore is actually very sweet once you get to know him.",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Theodore",
                            PokemonType = "Phantump"
                        },
                        new
                        {
                            Id = 11,
                            Age = 4,
                            BattleType = "Psychic",
                            Description = "Dropped off at our center as an egg, Oakley is fairly mild mannered and prefers to be alone most days. However, despite not wanting to play with the other Pokémon, Oakley will often be found close by to an employee, most often just watching as we go about our work.",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = true,
                            Name = "Oakley",
                            PokemonType = "Espurr"
                        },
                        new
                        {
                            Id = 12,
                            Age = 13,
                            BattleType = "Psychic/Fairy",
                            Description = "This Pokémon is currently still in rehabilitation. Please be patient with her!",
                            ImageOfPokemon = "/images/Placeholder.png",
                            IsAvailable = false,
                            Name = "Jade",
                            PokemonType = "Kirlia"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}