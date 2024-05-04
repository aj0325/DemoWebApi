using Demo.DemoCBIA.Models;
using DevExpress.Maui.DataGrid;
using DevExpress.Maui.DataForm;
using Demo.DemoCBIA.ViewModels;
namespace Demo.DemoCBIA.Pages;

public partial class GoingAwayForm : ContentPage
{
    private TripsViewModel _viewModel;

    public GoingAwayForm(TripsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        var newTrip = new Trip
        {
            Name = tripNameEntry.Text,
            Location = destinationEntry.Text,
            DepartureDate = departureDate.Date,
            ReturnDate = returnDate.Date,
            GoingFormFilled = true,
            FullName = studentNameEntry.Text,
            StudentId = studentIdEntry.Text,
            PhoneNumber = phoneNumber.Text,
            
            Purpose = purposeEditor.Text,
        };

        _viewModel.AddTrip(newTrip);
        await DisplayAlert("Success", "Trip details added.", "OK");
        await Shell.Current.GoToAsync("//TripsPage");

    }
}