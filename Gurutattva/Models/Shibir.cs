using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Gurutattva.Models
{
    public class Shibir
    {
        public int? Id { get; set; }

        [DisplayName("First Name")] public string FirstName { get; set; }

        [DisplayName("Last Name")] public string LastName { get; set; }
       
        [DisplayName("Phone Number")] public string PhoneNumber { get; set; }

        [DisplayName("Email Address")]public string EmailAddress { get; set; }

        [DisplayName("Start Date")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [BindProperty, DataType(DataType.Date)] 
        public DateTime EndDate { get; set; }

        [DisplayName("Start Time")]
        [BindProperty, DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        
        [DisplayName("End Time")]
        [BindProperty, DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public ShibirName ShibirName { get; set; }

        [DisplayName("Sitting Capacity")] public int Capacity { get; set; }

        [DisplayName("Street Address")] public string StreetAddress1 { get; set; }

        [DisplayName("Street Address 2")] public string StreetAddress2 { get; set; }

        [DisplayName("Pin Code")] 
        public string PinCode { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        //public int CountryId { get; set; }

        [DisplayName("Country")]
        public string CountryName { get; set; }

        //[DisplayName("State")] public int StateId { get; set; }

        [DisplayName("State")] public string StateName { get; set; }

        //[DisplayName("District")] public int DistrictId { get; set; }

        [DisplayName("District")] public string DistrictName { get; set; }

        //[DisplayName("Taluka (Tehsil)")] public int TalukaId { get; set; }

        [DisplayName("Taluka")] public string TalukaName { get; set; }

        //[DisplayName("City")] public int CityId { get; set; }

        [DisplayName("City")] public string CityName { get; set; }

        [DisplayName("Sanchalak Name")] public string SanchalakName1 { get; set; }

        [DisplayName("Email")] public string SanchalakEmail1 { get; set; }

        [DisplayName("Phone Number")] public string SanchalakPhoneNumber1 { get; set; }

        [DisplayName("Sanchalak Name 2")] public string SanchalakName2 { get; set; }

        [DisplayName("Email 2")] public string SanchalakEmail2 { get; set; }

        [DisplayName("Phone Number 2")] public string SanchalakPhoneNumber2 { get; set; }

        //public State State { get; set; }

        //public District District { get; set; }

        //public Taluka Taluka { get; set; }

        //public City City { get; set; }

    }


    public class ShibirValidator : AbstractValidator<Shibir>
    {
        public ShibirValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().MaximumLength(30);
            RuleFor(c => c.LastName).NotEmpty().MaximumLength(30);
            RuleFor(c => c.PhoneNumber).NotEmpty();
            RuleFor(c => c.EmailAddress).NotEmpty().MaximumLength(152).EmailAddress();
            RuleFor(c=>c.StartDate).NotEmpty();
            RuleFor(c => c.ShibirName).NotEmpty();
            RuleFor(c=>c.Capacity).NotEmpty();
            //RuleFor(c=>c.StreetAddress1).NotEmpty();
            //RuleFor(c => c.PinCode).NotEmpty();
            RuleFor(C => C.StateName).NotEmpty();
            RuleFor(c=>c.DistrictName).NotEmpty();
            RuleFor(c => c.TalukaName).NotEmpty();
            RuleFor(c => c.CityName).NotEmpty();
          

            RuleFor(c => c.Latitude).Must(c => c <= 90 && c >= -90)
                .WithMessage("Latitude must be between -90 <-> 90 degrees").NotNull().When(c => c.Longitude != null);
            RuleFor(c => c.Longitude).Must(c => c <= 180 && c >= -180)
                .WithMessage("Longitude must be between -180 <-> 180 degrees").NotNull().When(c => c.Latitude != null);

            RuleFor(c => c.StreetAddress1).NotEmpty().MaximumLength(150);
            RuleFor(c => c.PinCode).NotEmpty().Matches(new Regex(@"^[1-9][0-9]{5}$"));

            RuleFor(c => c.SanchalakName1).NotEmpty().MaximumLength(152).Matches(new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"));
            RuleFor(c => c.SanchalakEmail1).NotEmpty().MaximumLength(152).EmailAddress();
            RuleFor(c => c.SanchalakPhoneNumber1).NotEmpty().MaximumLength(10);

            RuleFor(c => c.SanchalakName2)
                .NotEmpty().When(c =>
                    !string.IsNullOrWhiteSpace(c.SanchalakEmail2) || !string.IsNullOrWhiteSpace(c.SanchalakPhoneNumber2))
                .MaximumLength(152).Matches(new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"));

            RuleFor(c => c.SanchalakEmail2)
                .NotEmpty().When(c =>
                    !string.IsNullOrWhiteSpace(c.SanchalakName2) || !string.IsNullOrWhiteSpace(c.SanchalakPhoneNumber2))
                .MaximumLength(152).EmailAddress();

            RuleFor(c => c.SanchalakPhoneNumber2)
                .NotEmpty().When(c =>
                    !string.IsNullOrWhiteSpace(c.SanchalakName2) || !string.IsNullOrWhiteSpace(c.SanchalakEmail2))
                .MaximumLength(10);
        }
    }
    //public enum City { 
    //    Sihor,
    //    Amreli,
    //    Lathi,
    //    Junagadh
    //}
    //public enum Taluka {
    //    Sihor,
    //    Gariyadhar,
    //    Usarad,
    //    Ugamedi
    //}
    //public enum State { 
    //    Gujarat,
    //    Maharastra,
    //    Hryana,
    //    Punjab,
    //    Rajasthan
    //}

    //public enum District
    //{ 
    //    Bhavnagar,
    //    Amreli,
    //    Goa,
    //    Shiroda
    //}
}
