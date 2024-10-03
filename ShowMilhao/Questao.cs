namespace ShowMilhao
{

    public class Questao : IEquatable <Questao>
   {
    public bool Equals (Questao q)
    {
      return this.Nivel==q.Nivel &&
      this.Pergunta==q.Pergunta;
    }
   
   public string Pergunta;
   public string RespostaUm;
   public string RespostaDois;
   public string RespostaTres;
   public string RespostaQuatro;
   public string RespostaCinco;
   public int RespostaCerta = 0;
   public int Nivel;
   private Label labelPergunta; 
   private Button buttonRespostaUm;
   private Button buttonRespostaDois;
   private Button buttonRespostaTres;
   private Button buttonRespostaQuatro;
   private Button buttonRespostaCinco;

   public Questao ()
   {

   }
   public void Desenhar ()
   {
     labelPergunta.Text        = Pergunta;
     buttonRespostaUm.Text     = RespostaUm;
     buttonRespostaDois.Text   = RespostaDois;
     buttonRespostaTres.Text   = RespostaTres;
     buttonRespostaQuatro.Text = RespostaQuatro;
     buttonRespostaCinco.Text  = RespostaCinco;

     buttonRespostaUm!.BackgroundColor = Color.FromArgb("#0a578f");
     buttonRespostaUm!.TextColor       = Colors.White;
     buttonRespostaDois!.BackgroundColor = Color.FromArgb("#0a578f");
     buttonRespostaDois!.TextColor       = Colors.White;
     buttonRespostaTres!.BackgroundColor = Color.FromArgb("#0a578f");
     buttonRespostaTres!.TextColor       = Colors.White;
     buttonRespostaQuatro!.BackgroundColor = Color.FromArgb("#0a578f");
     buttonRespostaQuatro!.TextColor       = Colors.White;
     buttonRespostaCinco!.BackgroundColor = Color.FromArgb("#0a578f");
     buttonRespostaCinco!.TextColor       = Colors.White;
   }
   public Questao (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
   {
     labelPergunta = labelPerg;
     buttonRespostaUm = btnResp01;
     buttonRespostaDois = btnResp02;
     buttonRespostaTres = btnResp03;
     buttonRespostaQuatro = btnResp04;
     buttonRespostaCinco = btnResp05;
   }
   public void ConfigurarDesenho (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
   {
     labelPergunta = labelPerg;
     buttonRespostaUm = btnResp01;
     buttonRespostaDois = btnResp02;
     buttonRespostaTres = btnResp03;
     buttonRespostaQuatro = btnResp04;
     buttonRespostaCinco = btnResp05;
   }
   public bool VerificaResposta (int RespostaEscolhida)
   {
     if ( RespostaEscolhida == RespostaCerta ) 
     {
        var b = Qual (RespostaEscolhida);
            b.BackgroundColor = Colors.Green;
        return true;
     }
     else
     {
        var bcerto = Qual (RespostaCerta);
        var berrado = Qual (RespostaEscolhida);
        bcerto.BackgroundColor = Color.FromArgb("#fad72a");
        berrado.BackgroundColor = Color.FromArgb("#d11702");
        return false;
     }
   }
   private Button Qual (int RespostaEscolhida)
   {
    if (RespostaEscolhida == 1 )
    return buttonRespostaUm;
    else if (RespostaEscolhida == 2)
    return buttonRespostaDois;
    else if (RespostaEscolhida == 3)
    return buttonRespostaTres;
    else if (RespostaEscolhida == 4)
    return buttonRespostaQuatro;
    else 
    return buttonRespostaCinco;
   }

   }
}