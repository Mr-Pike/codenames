﻿// <auto-generated />
using System;
using CodeNames.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeNames.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190424082802_SeedParametersTable")]
    partial class SeedParametersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeNames.Models.Games", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<short>("NextToPlayTeamId")
                        .HasColumnType("smallint(6)");

                    b.Property<short>("RoundBlueTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint(6)")
                        .HasDefaultValueSql("'0'");

                    b.Property<short>("RoundRedTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint(6)")
                        .HasDefaultValueSql("'0'");

                    b.Property<short>("ScoreBlueTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint(6)")
                        .HasDefaultValueSql("'0'");

                    b.Property<short>("ScoreRedTeam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint(6)")
                        .HasDefaultValueSql("'0'");

                    b.Property<short>("StartTeamId")
                        .HasColumnType("smallint(6)");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("NextToPlayTeamId")
                        .HasName("FK_Games_Teams_NextToPlayTeamId");

                    b.HasIndex("StartTeamId")
                        .HasName("FK_Games_Teams_StartTeamId");

                    b.ToTable("games");
                });

            modelBuilder.Entity("CodeNames.Models.GamesView", b =>
                {
                    b.Property<int>("GameId");

                    b.Property<int>("WordId");

                    b.Property<string>("BackgroundColorName");

                    b.Property<string>("ColorName");

                    b.Property<bool?>("Find");

                    b.Property<short>("Order");

                    b.Property<short>("TeamId");

                    b.Property<string>("WordName");

                    b.HasKey("GameId", "WordId")
                        .HasName("PRIMARY");

                    b.ToTable("_gamesview");
                });

            modelBuilder.Entity("CodeNames.Models.Gameswords", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int(11)");

                    b.Property<int>("WordId")
                        .HasColumnType("int(11)");

                    b.Property<bool?>("Find")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit(1)")
                        .HasDefaultValueSql("'b\\'0\\''");

                    b.Property<short>("Order")
                        .HasColumnType("smallint(6)");

                    b.Property<short>("TeamId")
                        .HasColumnType("smallint(6)");

                    b.HasKey("GameId", "WordId")
                        .HasName("PRIMARY");

                    b.HasIndex("TeamId")
                        .HasName("FK_GamesWords_Teams_TeamId");

                    b.HasIndex("WordId")
                        .HasName("FK_GamesWords_Words_WordId");

                    b.ToTable("gameswords");
                });

            modelBuilder.Entity("CodeNames.Models.Parameters", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ParameterNameIndex");

                    b.ToTable("parameters");
                });

            modelBuilder.Entity("CodeNames.Models.Teams", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint(6)");

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Color")
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("TeamNameIndex");

                    b.ToTable("teams");
                });

            modelBuilder.Entity("CodeNames.Models.Themes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ThemeNameIndex");

                    b.ToTable("themes");
                });

            modelBuilder.Entity("CodeNames.Models.Themeswords", b =>
                {
                    b.Property<int>("ThemeId")
                        .HasColumnType("int(11)");

                    b.Property<int>("WordId")
                        .HasColumnType("int(11)");

                    b.HasKey("ThemeId", "WordId")
                        .HasName("PRIMARY");

                    b.HasIndex("WordId")
                        .HasName("FK_ThemesWords_Words_WordId");

                    b.ToTable("themeswords");
                });

            modelBuilder.Entity("CodeNames.Models.Words", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("WordsNameIndex");

                    b.ToTable("words");
                });

            modelBuilder.Entity("CodeNames.Models.WordsView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ThemesName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("_wordsview");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CodeNames.Models.Games", b =>
                {
                    b.HasOne("CodeNames.Models.Teams", "NextToPlayTeam")
                        .WithMany("GamesNextToPlayTeam")
                        .HasForeignKey("NextToPlayTeamId")
                        .HasConstraintName("FK_Games_Teams_NextToPlayTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNames.Models.Teams", "StartTeam")
                        .WithMany("GamesStartTeam")
                        .HasForeignKey("StartTeamId")
                        .HasConstraintName("FK_Games_Teams_StartTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNames.Models.Gameswords", b =>
                {
                    b.HasOne("CodeNames.Models.Games", "Game")
                        .WithMany("Gameswords")
                        .HasForeignKey("GameId")
                        .HasConstraintName("FK_GamesWords_Games_GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNames.Models.Teams", "Team")
                        .WithMany("Gameswords")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("FK_GamesWords_Teams_TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNames.Models.Words", "Word")
                        .WithMany("Gameswords")
                        .HasForeignKey("WordId")
                        .HasConstraintName("FK_GamesWords_Words_WordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeNames.Models.Themeswords", b =>
                {
                    b.HasOne("CodeNames.Models.Themes", "Theme")
                        .WithMany("Themeswords")
                        .HasForeignKey("ThemeId")
                        .HasConstraintName("FK_ThemesWords_Themes_ThemeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeNames.Models.Words", "Word")
                        .WithMany("Themeswords")
                        .HasForeignKey("WordId")
                        .HasConstraintName("FK_ThemesWords_Words_WordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
