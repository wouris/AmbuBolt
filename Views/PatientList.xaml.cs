using System.Diagnostics;

namespace AmbuBolt.Views;


public partial class PatientList : ContentPage
{
    List<Patient> patients = new List<Patient>();
    List<Patient> patientss = new List<Patient> { new Patient("Yes", 5, "No", "Maybe") };
    RestService restService;
    public PatientList()
	{
        InitializeComponent();
		restService = new RestService();
	
		patientList.ItemsSource = patientss;
	}

    public async void RefreshButton_Clicked(object sender, EventArgs e)
    {
        patients = await restService.GetPatientList();

        patientList.ItemsSource = null;
        patientList.ItemsSource = patients;
    }
}