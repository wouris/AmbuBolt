namespace AmbuBolt.Views;

public partial class MedFormNav : ContentPage
{
	public MedFormNav()
	{
		InitializeComponent();
	}

    private void btnAddPatient_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MedFormAdd));
    }

    private void btnEditPatient_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(PatientList));
    }
}