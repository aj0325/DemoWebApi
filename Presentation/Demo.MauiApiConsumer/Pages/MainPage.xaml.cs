using Demo.ApiClient;
using Demo.ApiClient.Models.ApiModels;
using Demo.MauiApiConsumer.Pages;

namespace Demo.MauiApiConsumer
{
    public partial class MainPage : ContentPage
    {
        private readonly DemoApiClientService _apiClient;

        public MainPage(DemoApiClientService apiClient)
        {
            InitializeComponent();

            _apiClient = apiClient;
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddEditCulturalEvent(_apiClient, null));
        }

        private async void btnShowCulturalEvents_Clicked(object sender, EventArgs e)
        {
            await LoadCulturalEvents();
        }

        private async void culturalEventListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var culturalEvent = (CulturalEvent)e.Item;
            var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

            switch(action)
            {
                case "Edit":
                    await Navigation.PushModalAsync(new AddEditCulturalEvent(_apiClient, culturalEvent));
                    break;
                case "Delete":
                    await _apiClient.DeleteCulturalEvent(culturalEvent.Id);
                    await LoadCulturalEvents();
                    break;
            }
        }

        private async Task LoadCulturalEvents()
        {
            var culturalEvents = await _apiClient.GetCulturalEvents();
            culturalEventListView.ItemsSource = culturalEvents;
        }
    }
}