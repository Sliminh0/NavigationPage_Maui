namespace NavigationPage;

public partial class SegundaPage : ContentPage
{
	public SegundaPage()
	{
		InitializeComponent();
	}

    private async void Onclicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TerceiraPage());
    }
}