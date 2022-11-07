using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
