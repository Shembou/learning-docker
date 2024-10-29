using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Site_Api.Entities;
using Site_Api.Models;

namespace Site_Api.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public ApplicationDbContext(IMapper mapper, IConfiguration configuration)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var pwHasher = new PasswordHasher<User>();

            var exampleUser = new User()
            {
                UserId = 1,
                UserName = "Przemas",
                Password = ""
            };

            exampleUser.Password = pwHasher.HashPassword(exampleUser, "karmelki1");

            modelBuilder.Entity<User>().HasData(exampleUser);

            using (StreamReader streamReader = new StreamReader("dummyData.json"))
            {
                string json = streamReader.ReadToEnd();
                List<ShowDto> showsList = JsonConvert.DeserializeObject<List<ShowDto>>(json)!;
                modelBuilder.Entity<Show>().HasData(_mapper.Map<IList<Show>>(showsList));
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
