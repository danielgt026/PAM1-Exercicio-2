namespace Notes;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();


    }
    private async void LearnMoreClicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");

    }
}