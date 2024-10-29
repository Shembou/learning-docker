﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Site_Api.DbContexts;

#nullable disable

namespace Site_Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241016182550_ChangedGenreToPlural")]
    partial class ChangedGenreToPlural
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Site_Api.Entities.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowId"));

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Awards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ImdbRating")
                        .HasColumnType("real");

                    b.Property<int>("ImdbVotes")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Metascore")
                        .HasColumnType("int");

                    b.Property<string>("Plot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Runtime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShowId");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            ShowId = 1,
                            Actors = "Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang",
                            Awards = "Won 3 Oscars. Another 80 wins & 121 nominations.",
                            Country = "USA, UK",
                            Director = "James Cameron",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjEyOTYyMzUxNl5BMl5BanBnXkFtZTcwNTg0MTUzNA@@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNzM2MDk3MTcyMV5BMl5BanBnXkFtZTcwNjg0MTUzNA@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTY2ODQ3NjMyMl5BMl5BanBnXkFtZTcwODg0MTUzNA@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTMxOTEwNDcxN15BMl5BanBnXkFtZTcwOTg0MTUzNA@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTYxMDg1Nzk1MV5BMl5BanBnXkFtZTcwMDk0MTUzNA@@._V1_SX1500_CR0,0,1500,999_AL_.jpg\"]",
                            ImdbRating = 7.9f,
                            ImdbVotes = 890617,
                            Language = "English, Spanish",
                            Metascore = 83,
                            Plot = "A paraplegic marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTYwOTEwNjAzMl5BMl5BanBnXkFtZTcwODc5MTUwMw@@._V1_SX300.jpg",
                            Rated = "PG-13",
                            Runtime = "162 min",
                            Title = "Avatar",
                            Type = 0,
                            Writer = "James Cameron",
                            Year = "2009"
                        },
                        new
                        {
                            ShowId = 2,
                            Actors = "Will Smith, Alice Braga, Charlie Tahan, Salli Richardson-Whitfield",
                            Awards = "9 wins & 21 nominations.",
                            Country = "USA",
                            Director = "Francis Lawrence",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTI0NTI4NjE3NV5BMl5BanBnXkFtZTYwMDA0Nzc4._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTIwMDg2MDU4M15BMl5BanBnXkFtZTYwMTA0Nzc4._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc5MDM1OTU5OV5BMl5BanBnXkFtZTYwMjA0Nzc4._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTA0MTI2NjMzMzFeQTJeQWpwZ15BbWU2MDMwNDc3OA@@._V1_.jpg\"]",
                            ImdbRating = 7.2f,
                            ImdbVotes = 533874,
                            Language = "English",
                            Metascore = 65,
                            Plot = "Years after a plague kills most of humanity and transforms the rest into monsters, the sole survivor in New York City struggles valiantly to find a cure.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMGE1OWZkZmItNmVhMC00YzAxLTgxOTctNjg3NWExM2RmOWJkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                            Rated = "PG-13",
                            Runtime = "101 min",
                            Title = "I Am Legend",
                            Type = 0,
                            Writer = "Mark Protosevich (screenplay), Akiva Goldsman (screenplay), Richard Matheson (novel), John William Corrington, Joyce Hooper Corrington",
                            Year = "2007"
                        },
                        new
                        {
                            ShowId = 3,
                            Actors = "Gerard Butler, Lena Headey, Dominic West, David Wenham",
                            Awards = "16 wins & 42 nominations.",
                            Country = "USA",
                            Director = "Zack Snyder",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTMwNTg5MzMwMV5BMl5BanBnXkFtZTcwMzA2NTIyMw@@._V1_SX1777_CR0,0,1777,937_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTQwNTgyNTMzNF5BMl5BanBnXkFtZTcwNDA2NTIyMw@@._V1_SX1777_CR0,0,1777,935_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc0MjQzOTEwMV5BMl5BanBnXkFtZTcwMzE2NTIyMw@@._V1_SX1777_CR0,0,1777,947_AL_.jpg\"]",
                            ImdbRating = 7.7f,
                            ImdbVotes = 611046,
                            Language = "English",
                            Metascore = 52,
                            Plot = "King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMjAzNTkzNjcxNl5BMl5BanBnXkFtZTYwNDA4NjE3._V1_SX300.jpg",
                            Rated = "R",
                            Runtime = "117 min",
                            Title = "300",
                            Type = 0,
                            Writer = "Zack Snyder (screenplay), Kurt Johnstad (screenplay), Michael Gordon (screenplay), Frank Miller (graphic novel), Lynn Varley (graphic novel)",
                            Year = "2006"
                        },
                        new
                        {
                            ShowId = 4,
                            Actors = "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth",
                            Awards = "Nominated for 1 Oscar. Another 34 wins & 75 nominations.",
                            Country = "USA",
                            Director = "Joss Whedon",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTA0NjY0NzE4OTReQTJeQWpwZ15BbWU3MDczODg2Nzc@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjE1MzEzMjcyM15BMl5BanBnXkFtZTcwNDM4ODY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjMwMzM2MTg1M15BMl5BanBnXkFtZTcwNjM4ODY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ4NzM2Mjc5MV5BMl5BanBnXkFtZTcwMTkwOTY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc3MzQ3NjA5N15BMl5BanBnXkFtZTcwMzY5OTY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg\"]",
                            ImdbRating = 8.1f,
                            ImdbVotes = 1003301,
                            Language = "English, Russian",
                            Metascore = 69,
                            Plot = "Earth's mightiest heroes must come together and learn to fight as a team if they are to stop the mischievous Loki and his alien army from enslaving humanity.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTk2NTI1MTU4N15BMl5BanBnXkFtZTcwODg0OTY0Nw@@._V1_SX300.jpg",
                            Rated = "PG-13",
                            Runtime = "143 min",
                            Title = "The Avengers",
                            Type = 0,
                            Writer = "Joss Whedon (screenplay), Zak Penn (story), Joss Whedon (story)",
                            Year = "2012"
                        },
                        new
                        {
                            ShowId = 5,
                            Actors = "Leonardo DiCaprio, Jonah Hill, Margot Robbie, Matthew McConaughey",
                            Awards = "Nominated for 5 Oscars. Another 35 wins & 154 nominations.",
                            Country = "USA",
                            Director = "Martin Scorsese",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BNDIwMDIxNzk3Ml5BMl5BanBnXkFtZTgwMTg0MzQ4MDE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc0NzAxODAyMl5BMl5BanBnXkFtZTgwMDg0MzQ4MDE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTExMDk1MDE4NzVeQTJeQWpwZ15BbWU4MDM4NDM0ODAx._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTg3MTY4NDk4Nl5BMl5BanBnXkFtZTgwNjc0MzQ4MDE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTgzMTg4MDI0Ml5BMl5BanBnXkFtZTgwOTY0MzQ4MDE@._V1_SY1000_CR0,0,1553,1000_AL_.jpg\"]",
                            ImdbRating = 8.2f,
                            ImdbVotes = 786985,
                            Language = "English, French",
                            Metascore = 75,
                            Plot = "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime, corruption and the federal government.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SX300.jpg",
                            Rated = "R",
                            Runtime = "180 min",
                            Title = "The Wolf of Wall Street",
                            Type = 0,
                            Writer = "Terence Winter (screenplay), Jordan Belfort (book)",
                            Year = "2013"
                        },
                        new
                        {
                            ShowId = 6,
                            Actors = "Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow",
                            Awards = "Won 1 Oscar. Another 39 wins & 134 nominations.",
                            Country = "USA, UK",
                            Director = "Christopher Nolan",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjA3NTEwOTMxMV5BMl5BanBnXkFtZTgwMjMyODgxMzE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMzQ5ODE2MzEwM15BMl5BanBnXkFtZTgwMTMyODgxMzE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTg4Njk4MzY0Nl5BMl5BanBnXkFtZTgwMzIyODgxMzE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMzE3MTM0MTc3Ml5BMl5BanBnXkFtZTgwMDIyODgxMzE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNjYzNjE2NDk3N15BMl5BanBnXkFtZTgwNzEyODgxMzE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\"]",
                            ImdbRating = 8.6f,
                            ImdbVotes = 937412,
                            Language = "English",
                            Metascore = 74,
                            Plot = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMjIxNTU4MzY4MF5BMl5BanBnXkFtZTgwMzM4ODI3MjE@._V1_SX300.jpg",
                            Rated = "PG-13",
                            Runtime = "169 min",
                            Title = "Interstellar",
                            Type = 0,
                            Writer = "Jonathan Nolan, Christopher Nolan",
                            Year = "2014"
                        },
                        new
                        {
                            ShowId = 7,
                            Actors = "Peter Dinklage, Lena Headey, Emilia Clarke, Kit Harington",
                            Awards = "Won 1 Golden Globe. Another 185 wins & 334 nominations.",
                            Country = "USA, UK",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BNDc1MGUyNzItNWRkOC00MjM1LWJjNjMtZTZlYWIxMGRmYzVlXkEyXkFqcGdeQXVyMzU3MDEyNjk@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BZjZkN2M5ODgtMjQ2OC00ZjAxLWE1MjMtZDE0OTNmNGM0NWEwXkEyXkFqcGdeQXVyNjUxNzgwNTE@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMDk4Y2Y1MDAtNGVmMC00ZTlhLTlmMmQtYjcyN2VkNzUzZjg2XkEyXkFqcGdeQXVyNjUxNzgwNTE@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNjZjNWIzMzQtZWZjYy00ZTkwLWJiMTYtOWRkZDBhNWJhY2JmXkEyXkFqcGdeQXVyMjk3NTUyOTc@._V1_SX1777_CR0,0,1777,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNTMyMTRjZWEtM2UxMS00ZjU5LWIxMTYtZDA5YmJhZmRjYTc4XkEyXkFqcGdeQXVyMjk3NTUyOTc@._V1_SX1777_CR0,0,1777,999_AL_.jpg\"]",
                            ImdbRating = 9.5f,
                            ImdbVotes = 1046830,
                            Language = "English",
                            Metascore = 0,
                            Plot = "While a civil war brews between several noble families in Westeros, the children of the former rulers of the land attempt to rise up to power. Meanwhile a forgotten race, bent on destruction, plans to return after thousands of years in the North.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMjM5OTQ1MTY5Nl5BMl5BanBnXkFtZTgwMjM3NzMxODE@._V1_SX300.jpg",
                            Rated = "TV-MA",
                            Runtime = "56 min",
                            Title = "Game of Thrones",
                            Type = 1,
                            Writer = "David Benioff, D.B. Weiss",
                            Year = "2011�"
                        },
                        new
                        {
                            ShowId = 8,
                            Actors = "Travis Fimmel, Clive Standen, Gustaf Skarsg�rd, Katheryn Winnick",
                            Awards = "Nominated for 7 Primetime Emmys. Another 17 wins & 49 nominations.",
                            Country = "Ireland, Canada",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjM5MTM1ODUxNV5BMl5BanBnXkFtZTgwNTAzOTI2ODE@._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNzU2NDcxODMyOF5BMl5BanBnXkFtZTgwNDAzOTI2ODE@._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjMzMzIzOTU2M15BMl5BanBnXkFtZTgwODMzMTkyODE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ2NTQ2MDA3NF5BMl5BanBnXkFtZTgwODkxMDUxODE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTcxOTQ3NTA5N15BMl5BanBnXkFtZTgwMzExMDUxODE@._V1_SY1000_SX1500_AL_.jpg\"]",
                            ImdbRating = 8.6f,
                            ImdbVotes = 198041,
                            Language = "English, Old English, Norse, Old, Latin",
                            Metascore = 0,
                            Plot = "The world of the Vikings is brought to life through the journey of Ragnar Lothbrok, the first Viking to emerge from Norse legend and onto the pages of history - a man on the edge of myth.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BOTEzNzI3MDc0N15BMl5BanBnXkFtZTgwMzk1MzA5NzE@._V1_SX300.jpg",
                            Rated = "TV-14",
                            Runtime = "44 min",
                            Title = "Vikings",
                            Type = 1,
                            Writer = "Michael Hirst",
                            Year = "2013�"
                        },
                        new
                        {
                            ShowId = 9,
                            Actors = "Ben McKenzie, Donal Logue, David Mazouz, Sean Pertwee",
                            Awards = "Nominated for 4 Primetime Emmys. Another 3 wins & 22 nominations.",
                            Country = "USA",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BNDI3ODYyODY4OV5BMl5BanBnXkFtZTgwNjE5NDMwMDI@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjA5OTExMTIwNF5BMl5BanBnXkFtZTgwMjI5NDMwMDI@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTA3MDY2NjA3MzBeQTJeQWpwZ15BbWU4MDU0MDkzODgx._V1_SX1499_CR0,0,1499,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjM3MzYzNDgzOV5BMl5BanBnXkFtZTgwMjQwOTM4ODE@._V1_SY1000_CR0,0,1498,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjQwODAyNjk0NF5BMl5BanBnXkFtZTgwODU4MzMyODE@._V1_SY1000_CR0,0,1500,1000_AL_.jpg\"]",
                            ImdbRating = 8f,
                            ImdbVotes = 133375,
                            Language = "English",
                            Metascore = 0,
                            Plot = "The story behind Detective James Gordon's rise to prominence in Gotham City in the years before Batman's arrival.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTY2MjMwNDE4OV5BMl5BanBnXkFtZTgwNjI1NjU0OTE@._V1_SX300.jpg",
                            Rated = "TV-14",
                            Runtime = "42 min",
                            Title = "Gotham",
                            Type = 1,
                            Writer = "Bruno Heller",
                            Year = "2014�"
                        },
                        new
                        {
                            ShowId = 10,
                            Actors = "Omari Hardwick, Joseph Sikora, Andy Bean, Lela Loren",
                            Awards = "1 win & 6 nominations.",
                            Country = "USA",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc2ODg0MzMzM15BMl5BanBnXkFtZTgwODYxODA5NTE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTcyMjA0MzczNV5BMl5BanBnXkFtZTgwNTIyODA5NTE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTk0MTI0NzQ2NV5BMl5BanBnXkFtZTgwMDkxODA5NTE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ4Mzk1ODcxM15BMl5BanBnXkFtZTgwNDQyODA5NTE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTUwNTE0NDI1M15BMl5BanBnXkFtZTgwMDQyODA5NTE@._V1_SY1000_SX1500_AL_.jpg\"]",
                            ImdbRating = 8f,
                            ImdbVotes = 14770,
                            Language = "English",
                            Metascore = 0,
                            Plot = "James \"Ghost\" St. Patrick, a wealthy New York night club owner who has it all, catering for the city's elite and dreaming big, lives a double life as a drug kingpin.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BOTA4NTkzMjUzOF5BMl5BanBnXkFtZTgwNzg5ODkxOTE@._V1_SX300.jpg",
                            Rated = "TV-MA",
                            Runtime = "50 min",
                            Title = "Power",
                            Type = 1,
                            Writer = "Courtney Kemp Agboh",
                            Year = "2014�"
                        },
                        new
                        {
                            ShowId = 11,
                            Actors = "Wagner Moura, Boyd Holbrook, Pedro Pascal, Joanna Christie",
                            Awards = "Nominated for 2 Golden Globes. Another 4 nominations.",
                            Country = "USA",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTk2MDMzMTc0MF5BMl5BanBnXkFtZTgwMTAyMzA1OTE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjIxMDkyOTEyNV5BMl5BanBnXkFtZTgwNjY3Mjc3OTE@._V1_SY1000_SX1500_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjA2NDUwMTU2NV5BMl5BanBnXkFtZTgwNTI1Mzc3OTE@._V1_SY1000_CR0,0,1499,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BODA1NjAyMTQ3Ml5BMl5BanBnXkFtZTgwNjI1Mzc3OTE@._V1_SY1000_CR0,0,1499,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTU0NzQ0OTAwNl5BMl5BanBnXkFtZTgwMDAyMzA1OTE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\"]",
                            ImdbRating = 8.9f,
                            ImdbVotes = 118680,
                            Language = "English, Spanish",
                            Metascore = 0,
                            Plot = "A chronicled look at the criminal exploits of Colombian drug lord Pablo Escobar.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTU0ODQ4NDg2OF5BMl5BanBnXkFtZTgwNzczNTE4OTE@._V1_SX300.jpg",
                            Rated = "TV-MA",
                            Runtime = "49 min",
                            Title = "Narcos",
                            Type = 1,
                            Writer = "Carlo Bernard, Chris Brancato, Doug Miro, Paul Eckstein",
                            Year = "2015�"
                        },
                        new
                        {
                            ShowId = 12,
                            Actors = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                            Awards = "Won 2 Golden Globes. Another 132 wins & 218 nominations.",
                            Country = "USA",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTgyMzI5NDc5Nl5BMl5BanBnXkFtZTgwMjM0MTI2MDE@._V1_SY1000_CR0,0,1498,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ2NDkwNDk5NV5BMl5BanBnXkFtZTgwNDM0MTI2MDE@._V1_SY1000_CR0,0,1495,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTM4NDcyNDMzMF5BMl5BanBnXkFtZTgwOTI0MTI2MDE@._V1_SY1000_CR0,0,1495,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTAzMTczMjM3NjFeQTJeQWpwZ15BbWU4MDc1MTI1MzAx._V1_SY1000_CR0,0,1495,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjA5MTE3MTgwMF5BMl5BanBnXkFtZTgwOTQxMjUzMDE@._V1_SX1500_CR0,0,1500,999_AL_.jpg\"]",
                            ImdbRating = 9.5f,
                            ImdbVotes = 889883,
                            Language = "English, Spanish",
                            Metascore = 0,
                            Plot = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's financial future.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ0ODYzODc0OV5BMl5BanBnXkFtZTgwMDk3OTcyMDE@._V1_SX300.jpg",
                            Rated = "TV-14",
                            Runtime = "49 min",
                            Title = "Breaking Bad",
                            Type = 1,
                            Writer = "Vince Gilligan",
                            Year = "2008�2013"
                        },
                        new
                        {
                            ShowId = 13,
                            Actors = "Rachel McAdams, Benedict Cumberbatch, Mads Mikkelsen, Tilda Swinton",
                            Awards = "N/A",
                            Country = "USA",
                            Director = "Scott Derrickson",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjM3ODc1ODI5Ml5BMl5BanBnXkFtZTgwODMzMDY3OTE@._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTgxNTAyNTU0NV5BMl5BanBnXkFtZTgwNzMzMDY3OTE@._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjE5NDc5NzUwNV5BMl5BanBnXkFtZTgwMDM3MDM2NzE@._V1_.jpg\"]",
                            ImdbRating = 0f,
                            ImdbVotes = 0,
                            Language = "English",
                            Metascore = 0,
                            Plot = "After his career is destroyed, a brilliant but arrogant and conceited surgeon gets a new lease on life when a sorcerer takes him under her wing and trains him to defend the world against evil.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BNjgwNzAzNjk1Nl5BMl5BanBnXkFtZTgwMzQ2NjI1OTE@._V1_SX300.jpg",
                            Rated = "N/A",
                            Runtime = "N/A",
                            Title = "Doctor Strange",
                            Type = 0,
                            Writer = "Scott Derrickson (screenplay), C. Robert Cargill (screenplay), Jon Spaihts (story by), Scott Derrickson (story by), C. Robert Cargill (story by), Steve Ditko (comic book)",
                            Year = "2016"
                        },
                        new
                        {
                            ShowId = 14,
                            Actors = "Felicity Jones, Riz Ahmed, Mads Mikkelsen, Ben Mendelsohn",
                            Awards = "1 nomination.",
                            Country = "USA",
                            Director = "Gareth Edwards",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjE3MzA4Nzk3NV5BMl5BanBnXkFtZTgwNjAxMTc1ODE@._V1_SX1777_CR0,0,1777,744_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNDMxMTQzMjQxM15BMl5BanBnXkFtZTgwNzAxMTc1ODE@._V1_SX1777_CR0,0,1777,744_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTUyNjkxOTk5NV5BMl5BanBnXkFtZTgwODAxMTc1ODE@._V1_SX1777_CR0,0,1777,744_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BNjM4MzExNDAyNl5BMl5BanBnXkFtZTgwOTAxMTc1ODE@._V1_SX1777_CR0,0,1777,744_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjE3NTgxMDcyNV5BMl5BanBnXkFtZTgwMDExMTc1ODE@._V1_SX1777_CR0,0,1777,744_AL_.jpg\"]",
                            ImdbRating = 0f,
                            ImdbVotes = 0,
                            Language = "English",
                            Metascore = 0,
                            Plot = "The Rebellion makes a risky move to steal the plans to the Death Star, setting up the epic saga to follow.",
                            Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjQyMzI2OTA3OF5BMl5BanBnXkFtZTgwNDg5NjQ0OTE@._V1_SY1000_CR0,0,674,1000_AL_.jpg",
                            Rated = "N/A",
                            Runtime = "N/A",
                            Title = "Rogue One: A Star Wars Story",
                            Type = 0,
                            Writer = "Chris Weitz (screenplay), Tony Gilroy (screenplay), John Knoll (story), Gary Whitta (story), George Lucas (characters)",
                            Year = "2016"
                        },
                        new
                        {
                            ShowId = 15,
                            Actors = "Michael Fassbender, Michael Kenneth Williams, Marion Cotillard, Jeremy Irons",
                            Awards = "N/A",
                            Country = "UK, France, USA, Hong Kong",
                            Director = "Justin Kurzel",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BN2EyYzgyOWEtNTY2NS00NjRjLWJiNDYtMWViMjg5MWZjYjgzXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwOWYzOTctOTc4My00ZmJkLTgzMTctMmUxNDI5ODQzYzNjXkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_SX1500_CR0,0,1500,999_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BZTY5ZGUxMTAtYTU0OC00NGQ2LTkzNzgtZGZmNjlmNjY3MGU0XkEyXkFqcGdeQXVyNTY0MTkxMTg@._V1_SY1000_CR0,0,1500,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BZjA0MWYwZTEtYzc5Yi00NGM2LTg1YTctNjY2YzQ0NDJhZDAwXkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_SY1000_CR0,0,1499,1000_AL_.jpg\"]",
                            ImdbRating = 0f,
                            ImdbVotes = 0,
                            Language = "English",
                            Metascore = 0,
                            Plot = "When Callum Lynch explores the memories of his ancestor Aguilar and gains the skills of a Master Assassin, he discovers he is a descendant of the secret Assassins society.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTU2MTQwMjU1OF5BMl5BanBnXkFtZTgwMDA5NjU5ODE@._V1_SX300.jpg",
                            Rated = "N/A",
                            Runtime = "N/A",
                            Title = "Assassin's Creed",
                            Type = 0,
                            Writer = "Bill Collage (screenplay), Adam Cooper (screenplay), Michael Lesslie (screenplay)",
                            Year = "2016"
                        },
                        new
                        {
                            ShowId = 16,
                            Actors = "Mahershala Ali, Mike Colter, Frankie Faison, Erik LaRay Harvey",
                            Awards = "N/A",
                            Country = "USA",
                            Director = "N/A",
                            Genres = "[]",
                            Images = "[\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjMxNjc1NjI0NV5BMl5BanBnXkFtZTgwNzA0NzY0ODE@._V1_SY1000_CR0,0,1497,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjI1MDg3NjY2OF5BMl5BanBnXkFtZTgwNDE1NDU4OTE@._V1_SY1000_CR0,0,1497,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BOTYzOTQyNDYxNl5BMl5BanBnXkFtZTgwNzA1NDU4OTE@._V1_SY1000_CR0,0,1498,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMTgxMjA3MTQ5Ml5BMl5BanBnXkFtZTgwOTA1NDU4OTE@._V1_SY1000_CR0,0,1498,1000_AL_.jpg\",\"https://images-na.ssl-images-amazon.com/images/M/MV5BMjMyNjg5ODYwNF5BMl5BanBnXkFtZTgwMTE1NDU4OTE@._V1_SY1000_CR0,0,1477,1000_AL_.jpg\"]",
                            ImdbRating = 0f,
                            ImdbVotes = 0,
                            Language = "English",
                            Metascore = 0,
                            Plot = "Given superstrength and durability by a sabotaged experiment, a wrongly accused man escapes prison to become a superhero for hire.",
                            Poster = "http://ia.media-imdb.com/images/M/MV5BMTcyMzc1MjI5MF5BMl5BanBnXkFtZTgwMzE4ODY2OTE@._V1_SX300.jpg",
                            Rated = "TV-MA",
                            Runtime = "55 min",
                            Title = "Luke Cage",
                            Type = 1,
                            Writer = "Cheo Hodari Coker",
                            Year = "2016�"
                        });
                });

            modelBuilder.Entity("Site_Api.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "AQAAAAIAAYagAAAAEODAFyZ6ggUs9U2kI/cTt9jB4JhpUM+PTtqL+hp2Tn7Ei3mlyIYXuNZ7g2jNbqAKHg==",
                            UserName = "Przemas"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
