using AmbuBolt.Views;

namespace AmbuBolt;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MedFormAdd), typeof(MedFormAdd));
        Routing.RegisterRoute(nameof(MedFormNav), typeof(MedFormNav));
		Routing.RegisterRoute(nameof(PatientList), typeof(PatientList));
    }
}
