namespace ShowMilhao
{
    public class Gerenciador
 {
    List <Questao> ListaQuestoes = new List <Questao> ();
    List <int> ListaQuestoesRespondidas = new List <int> ();
    Questao QuestaoCorrente;

    public Gerenciador (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05 )
     {
        CriaPerguntas ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05 );
     }

    void CriaPerguntas (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05 )
    {
       var Q1= new Questao();
       Q1.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q1.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
       Q1.RespostaUm="1959";
       Q1.RespostaDois="1965";
       Q1.RespostaTres="1969";
       Q1.RespostaQuatro="1975";
       Q1.RespostaCinco="1980";
       Q1.RespostaCerta= 3;
       ListaQuestoes.Add(Q1);

       var Q2= new Questao();
       Q2.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q2.Pergunta = "Qual é a capital da França?";
       Q2.RespostaUm="Berlim";
       Q2.RespostaDois="Madri";
       Q2.RespostaTres="Roma";
       Q2.RespostaQuatro="Paris";
       Q2.RespostaCinco="Lisboa";
       Q2.RespostaCerta=4;
       ListaQuestoes.Add (Q2);

       var Q3= new Questao();
       Q3.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q3.Pergunta = "Qual é o elemento químico de número atômico 6?";
       Q3.RespostaUm=" Hidrogênio";
       Q3.RespostaDois=" Oxigênio";
       Q3.RespostaTres="Carbono";
       Q3.RespostaQuatro="Ferro";
       Q3.RespostaCinco="Nitrogênio";
       Q3.RespostaCerta=3;
       ListaQuestoes.Add (Q3);

       var Q4= new Questao();
       Q4.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q4.Pergunta = "Quem escreveu Dom Quixote?";
       Q4.RespostaUm="William Shakespeare";
       Q4.RespostaDois="Miguel de Cervantes";
       Q4.RespostaTres="Fernando Pessoa";
       Q4.RespostaQuatro="João Cabral de Melo Neto";
       Q4.RespostaCinco="Luís de Camões";
       Q4.RespostaCerta=2;
       ListaQuestoes.Add (Q4);

       var Q5= new Questao();
       Q5.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q5.Pergunta = "Qual é o maior planeta do sistema solar?";
       Q5.RespostaUm="Terra";
       Q5.RespostaDois="Marte";
       Q5.RespostaTres="Saturno";
       Q5.RespostaQuatro=" Júpiter";
       Q5.RespostaCinco="Vênus";
       Q5.RespostaCerta=4;
       ListaQuestoes.Add (Q5);

       var Q6= new Questao();
       Q6.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q6.Pergunta = "Qual é o símbolo químico da prata?";
       Q6.RespostaUm="Ag";
       Q6.RespostaDois="Au";
       Q6.RespostaTres="Pb";
       Q6.RespostaQuatro="Fe";
       Q6.RespostaCinco="Cu";
       Q6.RespostaCerta=4;
       ListaQuestoes.Add (Q6);

       var Q7= new Questao();
       Q7.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q7.Pergunta = "Quem pintou a obra Mona Lisa?";
       Q7.RespostaUm="Michelangelo";
       Q7.RespostaDois="Leonardo da Vinci";
       Q7.RespostaTres="Pablo Picasso";
       Q7.RespostaQuatro="Salvador Dalí";
       Q7.RespostaCinco="Vincent van Gogh";
       Q7.RespostaCerta=2;
       ListaQuestoes.Add (Q7);

       var Q8= new Questao();
       Q8.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q8.Pergunta = "Qual é o país mais populoso do mundo?";
       Q8.RespostaUm="Estados Unidos";
       Q8.RespostaDois="Índia";
       Q8.RespostaTres="China";
       Q8.RespostaQuatro="Rússia";
       Q8.RespostaCinco="Brasil";
       Q8.RespostaCerta=3;
       ListaQuestoes.Add (Q8);

       var Q9= new Questao();
       Q9.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q9.Pergunta = "Qual é a velocidade da luz no vácuo?";
       Q9.RespostaUm="150.000 km/s";
       Q9.RespostaDois="300.000 km/s";
       Q9.RespostaTres="450.000 km/s";
       Q9.RespostaQuatro="600.000 km/s";
       Q9.RespostaCinco="750.000 km/s";
       Q9.RespostaCerta=2;
       ListaQuestoes.Add (Q9);

       var Q10= new Questao();
       Q10.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q10.Pergunta = "Quem foi o primeiro presidente do Brasil?";
       Q10.RespostaUm="Getúlio Vargas";
       Q10.RespostaDois="Juscelino Kubitschek";
       Q10.RespostaTres=" Deodoro da Fonseca";
       Q10.RespostaQuatro="Floriano Peixoto";
       Q10.RespostaCinco="João Goulart";
       Q10.RespostaCerta=3;
       ListaQuestoes.Add (Q10);

       var Q11= new Questao();
       Q11.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q11.Pergunta = "Em qual continente está localizado o Egito?";
       Q11.RespostaUm="Ásia";
       Q11.RespostaDois=" África";
       Q11.RespostaTres="Europa";
       Q11.RespostaQuatro="América do Sul";
       Q11.RespostaCinco="Oceania";
       Q11.RespostaCerta=2;
       ListaQuestoes.Add (Q11);

       var Q12= new Questao();
       Q12.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q12.Pergunta = "Qual desses animais é um mamífero?";
       Q12.RespostaUm="Pinguim";
       Q12.RespostaDois="Tubarão";
       Q12.RespostaTres="Golfinho";
       Q12.RespostaQuatro="Jacaré";
       Q12.RespostaCinco="Salamandra";
       Q12.RespostaCerta=3;
       ListaQuestoes.Add (Q12);

       var Q13= new Questao();
       Q13.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q13.Pergunta = "Quantos estados existem no Brasil?";
       Q13.RespostaUm="26";
       Q13.RespostaDois="25";
       Q13.RespostaTres="27";
       Q13.RespostaQuatro="28";
       Q13.RespostaCinco="29";
       Q13.RespostaCerta=3;
       ListaQuestoes.Add (Q13);

       var Q14= new Questao();
       Q14.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q14.Pergunta = "Qual é o maior oceano do mundo?";
       Q14.RespostaUm=" Atlântico";
       Q14.RespostaDois=" Índico";
       Q14.RespostaTres="Ártico";
       Q14.RespostaQuatro="Pacífico";
       Q14.RespostaCinco="Antártico";
       Q14.RespostaCerta=4;
       ListaQuestoes.Add (Q14);

       var Q15= new Questao();
       Q15.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q15.Pergunta = "Qual é o órgão responsável pela circulação do sangue no corpo humano?";
       Q15.RespostaUm="Pulmão";
       Q15.RespostaDois="Estômago";
       Q15.RespostaTres="Rim";
       Q15.RespostaQuatro="Fígado";
       Q15.RespostaCinco="Coração";
       Q15.RespostaCerta=5;
       ListaQuestoes.Add (Q15);

       var Q16= new Questao();
       Q16.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q16.Pergunta = "Em que país se encontra a Torre Eiffel?";
       Q16.RespostaUm="Itália";
       Q16.RespostaDois="Espanha";
       Q16.RespostaTres="França";
       Q16.RespostaQuatro="Alemanha";
       Q16.RespostaCinco="Suíça";
       Q16.RespostaCerta=3;
       ListaQuestoes.Add (Q16);

       var Q17= new Questao();
       Q17.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q17.Pergunta = "Qual é a fórmula química da água?";
       Q17.RespostaUm="H2O";
       Q17.RespostaDois="CO2";
       Q17.RespostaTres="O2";
       Q17.RespostaQuatro="NaCl";
       Q17.RespostaCinco="CH4";
       Q17.RespostaCerta=1;
       ListaQuestoes.Add (Q17);

       var Q18= new Questao();
       Q18.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q18.Pergunta = "Quem foi o autor de O Pequeno Príncipe?";
       Q18.RespostaUm="J.K. Rowling";
       Q18.RespostaDois="Antoine de Saint-Exupéry";
       Q18.RespostaTres="George Orwell";
       Q18.RespostaQuatro="Mark Twain";
       Q18.RespostaCinco="Franz Kafka";
       Q18.RespostaCerta=2;
       ListaQuestoes.Add (Q18);

       var Q19= new Questao();
       Q19.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q19.Pergunta = "Em qual país nasceu o futebol moderno?";
       Q19.RespostaUm="Espanha";
       Q19.RespostaDois="Brasil";
       Q19.RespostaTres="Alemanha";
       Q19.RespostaQuatro="Inglaterra";
       Q19.RespostaCinco="Itália";
       Q19.RespostaCerta=4;
       ListaQuestoes.Add (Q19);

       var Q20= new Questao();
       Q20.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q20.Pergunta = "Qual é o menor país do mundo?";
       Q20.RespostaUm="Vaticano";
       Q20.RespostaDois="Mônaco";
       Q20.RespostaTres="San Marino";
       Q20.RespostaQuatro="Liechtenstein";
       Q20.RespostaCinco="Malta";
       Q20.RespostaCerta=1;
       ListaQuestoes.Add (Q20);
       ProximaQuestao();
      }

       public async void VerificaCorreta (int RespostaEscolhida)
       {
        if (QuestaoCorrente.VerificaResposta(RespostaEscolhida))
        {
            await Task.Delay(1000);
            ProximaQuestao();
        }
       }

       void ProximaQuestao()
       {
        var nAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(nAleat))
               nAleat= Random.Shared.Next (0, ListaQuestoes.Count);

        ListaQuestoesRespondidas.Add(nAleat);
        QuestaoCorrente = ListaQuestoes [nAleat];
        QuestaoCorrente.Desenhar ();
       }
    

 }

}
