using Labb2API.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Labb3API.API.Model
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }   
        public DbSet<JoinTableUserHobby> JoinHobbyUser { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed User

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                FirstName = "Klara",
                LastName = "Berg",
                Email = "Klara.Berg@Email.com",
                Phone = "0731509837",
                Age = new DateTime(1992, 06, 10)
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                FirstName = "Nalle",
                LastName = "Puh",
                Email = "NallePuh@Honung.com",
                Phone = "0731121122",
                Age = new DateTime(2013, 10, 14)
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 3,
                FirstName = "Olivia",
                LastName = "Walter",
                Email = "Olivia.Walter@Email.com",
                Phone = "0731502323",
                Age = new DateTime(1997, 03, 28)
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 4,
                FirstName = "Joakim",
                LastName = "Björklund",
                Email = "Joakim.Bjorklund@Email.com",
                Phone = "0708893321",
                Age = new DateTime(1996, 01, 15)
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 5,
                FirstName = "Zelda",
                LastName = "Pyttepatte",
                Email = "Zelda.Pyttepatte@Miaumail.com",
                Phone = "0703332221",
                Age = new DateTime(2020, 01, 05)
            });

            //Seed Hobby

            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyId = 1,
                HobbyTitle = "Floorboll",
                HobbyDescription = "Floorball is a type of floor hockey with five players and a goalkeeper in each team."
            });
            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyId = 2,
                HobbyTitle = "Game Development",
                HobbyDescription = "Game Development is the art of creating games and describes the design, development and release of a game."
            });
            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyId = 3,
                HobbyTitle = "Beekeeping",
                HobbyDescription = "Beekeeping (or apiculture) is the maintenance of bee colonies, commonly in man-made hives, by humans."
            });
            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyId = 4,
                HobbyTitle = "Sleeping",
                HobbyDescription = "Sleep is associated with a state of muscle relaxation and reduced perception of environmental stimuli."
            });
            modelBuilder.Entity<Hobby>().HasData(new Hobby
            {
                HobbyId = 5,
                HobbyTitle = "Hiking",
                HobbyDescription = "Hiking is a long, vigorous walk, usually on trails or footpaths in the countryside."
            });

            //Seed Link
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkId = 1,
                LinkDescription = "A Webside to the national swedish floorball commitee",
                LinkUrl = "https://www.innebandy.se/",
                UserId = 4,
                HobbyId = 1,
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkId = 2,
                LinkDescription = "A Webside with all new about swedish floorball",
                LinkUrl = "https://innebandymagazinet.se/",
                UserId = 1,
                HobbyId = 1,
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkId = 3,
                LinkDescription = "A Link to a Youtube-video with 10 music for deep sleep",
                LinkUrl = "https://www.youtube.com/watch?v=rulvcTfez5w",
                UserId = 5,
                HobbyId = 4,
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkId = 4,
                LinkDescription = "A Webside for the best hiking trails in Sweden",
                LinkUrl = "https://visitsweden.com/what-to-do/nature-outdoors/hiking/top-hiking-routes-sweden/",
                UserId = 1,
                HobbyId = 5,
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkId = 5,
                LinkDescription = "A Website for all the latest news in game development",
                LinkUrl = "https://www.gamedeveloper.com/",
                UserId = 3,
                HobbyId = 2,
            });
            modelBuilder.Entity<Link>().HasData(new Link
            {
                LinkId = 6,
                LinkDescription = "A Webside with tips and tricks for beekeeping beginners",
                LinkUrl = "https://beebuilt.com/pages/beekeeping-for-beginners",
                UserId = 2,
                HobbyId = 3,
            });

            //Seed JoinTableUserHobby

            modelBuilder.Entity<JoinTableUserHobby>().HasData(new JoinTableUserHobby
            {
                JoinId = 1,
                HobbyId = 1,
                UserId = 1,

            });
            modelBuilder.Entity<JoinTableUserHobby>().HasData(new JoinTableUserHobby
            {
                JoinId = 2,
                HobbyId = 1,
                UserId = 4,

            });
            modelBuilder.Entity<JoinTableUserHobby>().HasData(new JoinTableUserHobby
            {
                JoinId = 3,
                HobbyId = 2,
                UserId = 3,

            });
            modelBuilder.Entity<JoinTableUserHobby>().HasData(new JoinTableUserHobby
            {
                JoinId = 4,
                HobbyId = 3,
                UserId = 2,

            });
            modelBuilder.Entity<JoinTableUserHobby>().HasData(new JoinTableUserHobby
            {
                JoinId = 5,
                HobbyId = 4,
                UserId = 5,

            });
            modelBuilder.Entity<JoinTableUserHobby>().HasData(new JoinTableUserHobby
            {
                JoinId = 6,
                HobbyId = 5,
                UserId = 1,
            });
        }
    }
}
