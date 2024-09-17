namespace ShowMilhao
{
    public class Questao 
 {
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
     labelPergunta.Text = Pergunta;
     buttonRespostaUm.Text = RespostaUm;
     buttonRespostaDois.Text = RespostaDois;
     buttonRespostaTres.Text = RespostaTres;
     buttonRespostaQuatro.Text = RespostaQuatro;
     buttonRespostaCinco.Text = RespostaCinco;
   }
   public Questao (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
   {
     labelPergunta = LP;
     buttonRespostaUm = bt01;
     buttonRespostaUm = bt02;
     buttonRespostaUm = bt03;
     buttonRespostaUm = bt04;
     buttonRespostaUm = bt05;
   }
   public void ConfigurarDesenho (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
   {
     labelPergunta = LP;
     buttonRespostaUm = bt01;
     buttonRespostaUm = bt02;
     buttonRespostaUm = bt03;
     buttonRespostaUm = bt04;
     buttonRespostaUm = bt05;
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
        bcerto.BackgroundColor = Colors.Yellow;
        berrado.BackgroundColor = Colors.Red;
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