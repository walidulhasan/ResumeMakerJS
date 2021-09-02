using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cvMakerApi.Models
{
    public class Country
    {
        public Country()
        {
            this.resumeMakers = new List<ResumeMaker>();
        }
        public int CountryId { get; set; }
        [Required,StringLength(200)]
        public string country { get; set; }
        //nav
        public ICollection<ResumeMaker> resumeMakers { get; set; }
    }
    public class ResumeMaker
    {
        public int ResumeMakerId { get; set; }
        [Required,StringLength(60)]
        public string Name { get; set; }
        [Required, StringLength(60)]
        public string Position { get; set; }
        [StringLength(200)]
        public string SocialorsiteA { get; set; }
        [StringLength(200)]
        public string SocialorsiteB { get; set; }
        [StringLength(200)]
        public string SocialorsiteC { get; set; }
        [Required,ForeignKey("country")]
        public int CountryId { get; set; }
        [Required,StringLength(300)]
        public string about { get; set; }
        public string servicesA { get; set; }
        public string servicesB { get; set; }
        public string educationorcrouseA { get; set; }
        public string educationorcrouseB { get; set; }
        public string educationorcrouseC { get; set; }
        public string educationorcrouseD { get; set; }
        public string picture { get; set; }
        //nav
        public  Country country { get; set; }
    }
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options) { }
        public DbSet<Country> countries { get; set; }
        public DbSet<ResumeMaker> resumeMakers { get; set; }
        public DbSet<User> users { get; set; }
    }
}
