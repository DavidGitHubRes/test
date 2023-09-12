namespace test;

public partial class MainPage : ContentPage
{
	personaBD _database;

	public MainPage()
	{
		InitializeComponent();
		_database = new personaBD(App.DBPath);
	}

    private async void guardar_Clicked(object sender, EventArgs e)
    {
        var newPersona = new personaModel()
        {
            Name = Nombre.Text,
        };

        await _database.SaveSurveyAsync(newPersona);

       await DisplayAlert("Success", "Se guardo correctamente", "Aceptar");

    }
}

