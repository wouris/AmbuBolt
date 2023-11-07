using AmbuBolt.Views;


namespace AmbuBolt;

public partial class MainPage : ContentPage
{
	int count = 0;
	RestService restService = new RestService();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        count++;

        String message = "Hello, world!";
		for (int i  = 0; i < count; i++)
		{
			message = message + "!";
		}
		
		Nigga.Text = message;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void Test_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MedFormNav));
    }

    private async void btn_RestApi_Clicked(object sender, EventArgs e)
    {
		await restService.SendPatientInfo(new Patient("penis", 2801 , "penis","penis"));
    }

    private async void btn_Get_Clicked(object sender, EventArgs e)
    {
		await restService.GetPatientList();
	}
}

