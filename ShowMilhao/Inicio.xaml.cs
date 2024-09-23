namespace ShowMilhao;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

	void Ir(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
	
	
}