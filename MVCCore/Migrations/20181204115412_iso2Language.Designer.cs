﻿// <auto-generated />
using MVCCore.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCCore.Migrations
{
    [DbContext(typeof(ArtifactContext))]
    [Migration("20181204115412_iso2Language")]
    partial class iso2Language
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCCore.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Armor");

                    b.Property<int>("Attack");

                    b.Property<int>("HitPoints");

                    b.Property<int>("cardSetId");

                    b.HasKey("CardId");

                    b.HasIndex("cardSetId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("MVCCore.Models.CardColour", b =>
                {
                    b.Property<int>("CardColourId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CardColourId");

                    b.ToTable("CardColours");
                });

            modelBuilder.Entity("MVCCore.Models.CardReferenceType", b =>
                {
                    b.Property<int>("CardReferenceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CardReferenceTypeId");

                    b.ToTable("CardReferenceTypes");
                });

            modelBuilder.Entity("MVCCore.Models.CardSet", b =>
                {
                    b.Property<int>("CardSetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SetId");

                    b.HasKey("CardSetId");

                    b.ToTable("CardSets");
                });

            modelBuilder.Entity("MVCCore.Models.CardType", b =>
                {
                    b.Property<int>("CardTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CardTypeId");

                    b.ToTable("CardTypes");
                });

            modelBuilder.Entity("MVCCore.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("iso2");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("MVCCore.Models.Card", b =>
                {
                    b.HasOne("MVCCore.Models.CardSet", "CardSet")
                        .WithMany("Cards")
                        .HasForeignKey("cardSetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}