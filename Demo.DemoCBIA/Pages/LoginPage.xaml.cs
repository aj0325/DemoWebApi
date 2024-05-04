using Demo.DemoCBIA.ViewModels;
namespace Demo.DemoCBIA.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
        ViewModel = new LoginViewModel();
        BindingContext = ViewModel;
        InitializeComponent();
        IsInitialized = true;
    }

    LoginViewModel ViewModel { get; }
    bool IsInitialized { get; }

    async void OnLoginClicked(object sender, EventArgs e)
    {

        //await Shell.Current.Navigation.PopToRootAsync();
        await Shell.Current.GoToAsync("//MainPage");
    }

    void OnTextEditTextChanged(System.Object sender, System.EventArgs e)
    {
        if (IsLoaded)
        {
            ViewModel.ValidateEditors();
        }
    }
}