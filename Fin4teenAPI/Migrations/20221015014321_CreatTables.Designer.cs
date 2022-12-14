// <auto-generated />
using Fin4teenAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fin4teenAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221015014321_CreatTables")]
    partial class CreatTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fin4teenAPI.Model.Book", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_book")
                        .HasColumnType("int");

                    b.Property<int>("pages")
                        .HasColumnType("int");

                    b.Property<string>("releaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlAmazon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("name");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Fin4teenAPI.Model.Movie", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_movie")
                        .HasColumnType("int");

                    b.Property<string>("releaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("time")
                        .HasColumnType("int");

                    b.Property<string>("urlAmazon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlApple")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlNetflix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("name");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Fin4teenAPI.Model.TvShow", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_TvShow")
                        .HasColumnType("int");

                    b.Property<string>("releaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("time")
                        .HasColumnType("int");

                    b.Property<string>("urlAmazon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlApple")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlNetflix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("name");

                    b.ToTable("TvShows");
                });
#pragma warning restore 612, 618
        }
    }
}
