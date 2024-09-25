namespace ShowMilhao
{
    public class Gerenciador
 {
    List <Questao> ListaQuestoes = new List <Questao> ();
    List <int> ListaQuestoesRespondidas = new List <int> ();
    public int Pontos {get; private set;}
    int NivelAtual =0;

    Label labelPontuacao;
    Label labelNivel;
    Questao QuestaoCorrente;

    public Gerenciador (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05, Label labelPontuacao, Label labelNivel )
     {
        CriaPerguntas ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05 );
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
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
       Q1.Nivel=1;
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
       Q2.Nivel=1;
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
       Q3.Nivel=1;
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
       Q4.Nivel=1;
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
       Q5.Nivel=1;
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
       Q6.Nivel=1;
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
       Q7.Nivel=1;
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
       Q8.Nivel=1;
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
       Q9.Nivel=1;
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
       Q10.Nivel=1;
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
       Q11.Nivel=1;
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
       Q12.Nivel=1;
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
       Q13.Nivel=1;
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
       Q14.Nivel=1;
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
       Q15.Nivel=1;
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
       Q16.Nivel=1;
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
       Q17.Nivel=1;
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
       Q18.Nivel=1;
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
       Q19.Nivel=1;
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
       Q20.Nivel=1;
       ListaQuestoes.Add (Q20);

       var Q21= new Questao();
       Q21.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q21.Pergunta = "Qual é o maior deserto do mundo?";
       Q21.RespostaUm="Saara";
       Q21.RespostaDois="Gobi";
       Q21.RespostaTres="Kalahari";
       Q21.RespostaQuatro=" Atacama";
       Q21.RespostaCinco="Antártico";
       Q21.RespostaCerta= 5;
       Q21.Nivel=1;
       ListaQuestoes.Add(Q21);

       var Q22= new Questao();
       Q22.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q22.Pergunta = "Qual é a maior floresta tropical do mundo?";
       Q22.RespostaUm="Floresta do Congo";
       Q22.RespostaDois="Floresta Amazônica";
       Q22.RespostaTres="Taiga";
       Q22.RespostaQuatro="Floresta Negra";
       Q22.RespostaCinco="Floresta da Birmânia";
       Q22.RespostaCerta=2;
       Q22.Nivel=1;
       ListaQuestoes.Add (Q22);

       var Q23= new Questao();
       Q23.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q23.Pergunta = "Qual é o metal mais leve?";
       Q23.RespostaUm=" Ouro";
       Q23.RespostaDois=" Ferro";
       Q23.RespostaTres="Lítio";
       Q23.RespostaQuatro="Cobre";
       Q23.RespostaCinco="Alimínio";
       Q23.RespostaCerta=3;
       Q23.Nivel=1;
       ListaQuestoes.Add (Q23);

       var Q24= new Questao();
       Q24.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q24.Pergunta = "Quem foi o fundador do Facebook?";
       Q24.RespostaUm=" Steve Jobs";
       Q24.RespostaDois=" Bill Gates";
       Q24.RespostaTres="Jeff Bezos";
       Q24.RespostaQuatro="Elon Musk";
       Q24.RespostaCinco="Mark Zuckerberg";
       Q24.RespostaCerta=5;
       Q24.Nivel=1;
       ListaQuestoes.Add (Q24);

       var Q25= new Questao();
       Q25.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q25.Pergunta = "Qual foi o primeiro homem a orbitar a Terra?";
       Q25.RespostaUm="Neil Armstrong";
       Q25.RespostaDois="Yuri Gagarin";
       Q25.RespostaTres="Buzz Aldrin";
       Q25.RespostaQuatro="Buzz Aldrin";
       Q25.RespostaCinco="Alan Shepard";
       Q25.RespostaCerta=2;
       Q25.Nivel=1;
       ListaQuestoes.Add (Q25);

       var Q26= new Questao();
       Q26.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q26.Pergunta = "Qual país é famoso pelos Alpes?";
       Q26.RespostaUm="França";
       Q26.RespostaDois="Suiça";
       Q26.RespostaTres="Itália";
       Q26.RespostaQuatro="Estados Unidos";
       Q26.RespostaCinco="Canadá";
       Q26.RespostaCerta=2;
       Q26.Nivel=1;
       ListaQuestoes.Add (Q26);

       var Q27= new Questao();
       Q27.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q27.Pergunta = "Quem compôs a Nona Sinfonia?";
       Q27.RespostaUm="Wolfgang Amadeus Mozart";
       Q27.RespostaDois=" Ludwig van Beethoven";
       Q27.RespostaTres=" Johann Sebastian Bach";
       Q27.RespostaQuatro="Antonio Vivaldi";
       Q27.RespostaCinco="Richard Wagner";
       Q27.RespostaCerta=2;
       Q27.Nivel=1;
       ListaQuestoes.Add (Q7);

       var Q28= new Questao();
       Q28.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q28.Pergunta = "Qual é o estado mais populoso do Brasil?";
       Q28.RespostaUm= "Rio de Janeiro";
       Q28.RespostaDois="Minas Gerais";
       Q28.RespostaTres="Bahia";
       Q28.RespostaQuatro="São Paulo";
       Q28.RespostaCinco="Paraná";
       Q28.RespostaCerta=4;
       Q28.Nivel=1;
       ListaQuestoes.Add (Q28);

       var Q29= new Questao();
       Q29.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q29.Pergunta = "Qual desses filósofos é conhecido por sua obra A República?";
       Q29.RespostaUm="Aristóteles";
       Q29.RespostaDois="Sócrates";
       Q29.RespostaTres=" Platão";
       Q29.RespostaQuatro=" Descartes";
       Q29.RespostaCinco="Nietzsche";
       Q29.RespostaCerta=3;
       Q29.Nivel=1;
       ListaQuestoes.Add (Q29);

       var Q30= new Questao();
       Q30.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q30.Pergunta = "Qual é o rio mais longo do mundo?";
       Q30.RespostaUm="Nilo";
       Q30.RespostaDois="Amazonas";
       Q30.RespostaTres="  Mississipi";
       Q30.RespostaQuatro="Yangtzé";
       Q30.RespostaCinco="Danúbio";
       Q30.RespostaCerta=1;
       Q30.Nivel=1;
       ListaQuestoes.Add (Q30);

       var Q31= new Questao();
       Q31.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q31.Pergunta = "Quem pintou A Última Ceia?";
       Q31.RespostaUm=" Michelangelo";
       Q31.RespostaDois=" Leonardo da Vinci";
       Q31.RespostaTres="Pablo Picasso";
       Q31.RespostaQuatro="Salvador Dalí";
       Q31.RespostaCinco="Vincent van Gogh";
       Q31.RespostaCerta=2;
       Q31.Nivel=1;
       ListaQuestoes.Add (Q31);

       var Q32= new Questao();
       Q32.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q32.Pergunta = " Qual é a montanha mais alta do mundo?";
       Q32.RespostaUm="Kilimanjaro";
       Q32.RespostaDois="K2";
       Q32.RespostaTres="Everest";
       Q32.RespostaQuatro=" Aconcágua";
       Q32.RespostaCinco=" Mont Blanc";
       Q32.RespostaCerta=3;
       Q32.Nivel=1;
       ListaQuestoes.Add (Q32);

       var Q33= new Questao();
       Q33.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q33.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
       Q33.RespostaUm="Abraham Lincoln";
       Q33.RespostaDois=" Thomas Jefferson";
       Q33.RespostaTres=" George Washington";
       Q33.RespostaQuatro=" John Adams";
       Q33.RespostaCinco="Theodore Roosevelt";
       Q33.RespostaCerta=3;
       Q33.Nivel=1;
       ListaQuestoes.Add (Q33);

       var Q34= new Questao();
       Q34.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q34.Pergunta = "Qual é a fórmula química do sal de cozinha?";
       Q34.RespostaUm=" H2SO4";
       Q34.RespostaDois=" NaCl";
       Q34.RespostaTres="KOH";
       Q34.RespostaQuatro=" C6H12O6";
       Q34.RespostaCinco="CO2";
       Q34.RespostaCerta=2;
       Q34.Nivel=1;
       ListaQuestoes.Add (Q34);

       var Q35= new Questao();
       Q35.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q35.Pergunta = "Qual é a capital do Japão?";
       Q35.RespostaUm=" Seul";
       Q35.RespostaDois="Pequim";
       Q35.RespostaTres="Tóquio";
       Q35.RespostaQuatro="Bangkok";
       Q35.RespostaCinco="Xangai";
       Q35.RespostaCerta=3;
       Q35.Nivel=1;
       ListaQuestoes.Add (Q35);

       var Q36= new Questao();
       Q36.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q36.Pergunta = "Quem foi o último faraó do Egito?";
       Q36.RespostaUm="Ramsés II";
       Q36.RespostaDois="Tutancâmon";
       Q36.RespostaTres="Akhenaton";
       Q36.RespostaQuatro="Cleópatra";
       Q36.RespostaCinco="Nefertiti";
       Q36.RespostaCerta=4;
       Q36.Nivel=1;
       ListaQuestoes.Add (Q36);

       var Q37= new Questao();
       Q37.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q37.Pergunta = "Qual desses países faz parte da Escandinávia?";
       Q37.RespostaUm=" França";
       Q37.RespostaDois="Alemanha";
       Q37.RespostaTres="Dinamarca";
       Q37.RespostaQuatro="Rússia";
       Q37.RespostaCinco=" Polônia";
       Q37.RespostaCerta=3;
       Q37.Nivel=1;
       ListaQuestoes.Add (Q37);

       var Q38= new Questao();
       Q38.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q38.Pergunta = "Qual é a cor da faixa do meio da bandeira da Itália?";
       Q38.RespostaUm="Vermelho";
       Q38.RespostaDois="Branco";
       Q38.RespostaTres="Verde";
       Q38.RespostaQuatro="Azul";
       Q38.RespostaCinco="Amarelo";
       Q38.RespostaCerta=2;
       Q38.Nivel=1;
       ListaQuestoes.Add (Q38);

       var Q39= new Questao();
       Q39.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q39.Pergunta = "Qual é o instrumento musical típico da Escócia?";
       Q39.RespostaUm="Violino";
       Q39.RespostaDois="Harpa";
       Q39.RespostaTres="Guitarra";
       Q39.RespostaQuatro="Gaita de foles";
       Q39.RespostaCinco="Saxofone";
       Q39.RespostaCerta=4;
       Q39.Nivel=1;
       ListaQuestoes.Add (Q39);

       var Q40= new Questao();
       Q40.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q40.Pergunta = "Qual é a principal fonte de energia do sol?";
       Q40.RespostaUm="Fissão nuclear";
       Q40.RespostaDois="Combustão";
       Q40.RespostaTres="Reações químicas";
       Q40.RespostaQuatro="Fusões nucleares";
       Q40.RespostaCinco="Magnetismo";
       Q40.RespostaCerta=4;
       Q40.Nivel=1;
       ListaQuestoes.Add (Q40);
       ProximaQuestao();
      }

       public async void VerificaCorreta (int RespostaEscolhida)
       {
        labelPontuacao.Text="Pontuação:" + Pontos.ToString();
        labelNivel.Text="Nivel:" + NivelAtual.ToString();
        if (QuestaoCorrente.VerificaResposta(RespostaEscolhida))
        {
            await Task.Delay(1000);
            AdicionaPontos (NivelAtual);
            if (NivelAtual == 10)
        {
            await App.Current.MainPage.DisplayAlert("PARABÉNS", "VOCÊ CHEGOU AO FIM", "OK");
            
        }
            NivelAtual ++;
            ProximaQuestao();
        }
        else 
        {
            
            await App.Current.MainPage.DisplayAlert("FIM", "VOCÊ ERROU", "OK");
            Inicializar();
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

       void Inicializar()
       {
         Pontos=0;
         NivelAtual=1;
         ProximaQuestao();
         ListaQuestoesRespondidas.Clear();
       }

       void AdicionaPontos (int n)
       {
         if (n==1)
         Pontos=1000;
         else if  (n==2)
         Pontos=2000;
         else if (n==3)
         Pontos=5000;
         else if (n==4)
         Pontos=10000;
         else if (n==5)
         Pontos=20000;
         else if (n==6)
         Pontos=50000;
         else if (n==7)
         Pontos=100000;
         else if (n==8)
         Pontos=200000;
         else if (n==9)
         Pontos=500000;
         else
         Pontos=1000000;
       }
 

 }

}
