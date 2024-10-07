
namespace ShowMilhao;

public partial class MainPage : ContentPage
{
    Gerenciador gerenciador;
	int pulou=1;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05, labelPontuacao, labelNivel );
	}

	void OnButtonRep1Clicked (object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(1);
	}
    void OnButtonRep2Clicked (object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void OnButtonRep3Clicked (object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
    void OnButtonRep4Clicked (object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}

	void OnButtonRep5Clicked (object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}

	void OnAjudaRetirarClicked (object s, EventArgs e)
	{
		var ajuda= new RetiraErradas ();
		ajuda.ConfigurarDesenho(btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=true;
	}

	void OnAjudaPulaClicked (object s, EventArgs e)
	{
		if (pulou==3)
		 (s as Button).IsVisible=false;
		else
		{
		 gerenciador.ProximaQuestao();
		 pulou++;
		}
	}

	void OnAjudaUniversitarioClicked (object s, EventArgs e)
	{
		var ajuda= new Universitarios ();
		ajuda.ConfigurarDesenho(btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=true;
	}
	
}

