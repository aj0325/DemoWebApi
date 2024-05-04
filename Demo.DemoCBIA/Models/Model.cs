using DevExpress.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.Models
{
    public class Trip
    {
        public string Name { get; set; } 
        public string Location { get; set; }
        public bool GoingFormFilled { get; set; }
        public string FullName { get; set; }
        public string StudentId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Purpose { get; set; }
    }


    public class CulturalEvent
    {
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool SignedUp { get; set; }
    }

    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string KeyDates { get; set; }
        public string Events { get; set; }
        public string Agreements { get; set; }
    }

    public class PdfModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class TripInformation
    {
        public string FullName { get; set; }
        public string StudentId { get; set; }
        public string PhoneNumber { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Purpose { get; set; }
        // Add other properties as needed (e.g., transportation, lodging, medical info)
    }
    public class ProfileInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string DietaryPreference { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string ImageSource { get; set; }
        public List<string> GenderOptions { get; } = new List<string> { "Female", "Male", "Other" };
        public List<string> DietaryOptions { get; } = new List<string> { "Vegetarian", "Non-Vegetarian", "Vegan" };
    }

    

    public class ProfileModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string DietaryPreference { get; set; }
        public string ImageSource { get; set; }
    }
}
