namespace test;

public partial class App : Application
{
    public static string DBPath { get; private set; }
    public static personaBD Database { get; private set; }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        DBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "personaBD.db3");
        Database = new personaBD(DBPath);
    }
}
