using Gurutattva.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Gurutattva.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Shibir> Shibirs { get; set; }
        //public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        //public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<PhoneNumber>().HasData(
            //    new PhoneNumber { Id = 1, CountryName = "India" , CountryCode = "+91"},
            //    new PhoneNumber { Id = 2, CountryName = "Canada", CountryCode = "+1" },
            //    new PhoneNumber { Id = 3, CountryName = "USA", CountryCode = "+1" }
            //);

            //modelBuilder.Entity<Address>().HasData(
            //    new Address
            //    {
            //        Id = 1,
            //        StreetAddress = "India",
            //        StreetAddress2 = "+91",
            //        City="Waterloo",
            //        State="Ontario",
            //        PostalCode="N2L0J9",
            //        Country="Canda"
            //    }

            //);


            modelBuilder.Entity<Shibir>().HasData(
                new Shibir
                {
                    Id = 1,
                    FirstName = "Jil",
                    LastName = "Mehta",
                    EmailAddress = "jilmehta52@gmaIL.com",
                    PhoneNumber = "6478321825",

                    StartDate = "2022/08/04",
         
                    StartTime = "16:00:00",
           
                    SanchalakName1 = "Sanchalak1",
                    SanchalakEmail1 = "SanchalakEmail1",
                    SanchalakPhoneNumber1 = "3456542312",
                    SanchalakEmail2 = "SanchalakEmail2",
                    SanchalakPhoneNumber2 = "3454637234",
                    SanchalakName2 = "SanchalakName2",
                    Capacity = 50,
                    PinCode = "364340",

                    CountryName = "India",
                    Address ="Dixon Street",
                    StateName = "Ontario",
                    DistrictName = "Kitchener",
                    TalukaName = "Waterloo",
                    CityName = "Waterloo"
                }
            );
        }
    }
}
