namespace ShowMilhao
{
    public class Gerenciador
 {
    List <Questao> ListaTodasQuestoes = new List <Questao> ();
    List <Questao> ListaTodasQuestoesRespondidas = new List <Questao> ();
    public int Pontos {get; private set;}
    int NivelAtual =1;

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
       ListaTodasQuestoes.Add(Q1);

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
       ListaTodasQuestoes.Add (Q2);

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
       ListaTodasQuestoes.Add (Q3);

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
       ListaTodasQuestoes.Add (Q4);

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
       ListaTodasQuestoes.Add (Q5);

       var Q6= new Questao();
       Q6.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q6.Pergunta = "Qual é o símbolo químico da prata?";
       Q6.RespostaUm="Ag";
       Q6.RespostaDois="Au";
       Q6.RespostaTres="Pb";
       Q6.RespostaQuatro="Fe";
       Q6.RespostaCinco="Cu";
       Q6.RespostaCerta=1;
       Q6.Nivel=1;
       ListaTodasQuestoes.Add (Q6);

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
       ListaTodasQuestoes.Add (Q7);

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
       ListaTodasQuestoes.Add (Q8);

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
       ListaTodasQuestoes.Add (Q9);

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
       ListaTodasQuestoes.Add (Q10);

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
       ListaTodasQuestoes.Add (Q11);

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
       ListaTodasQuestoes.Add (Q12);

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
       ListaTodasQuestoes.Add (Q13);

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
       ListaTodasQuestoes.Add (Q14);

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
       ListaTodasQuestoes.Add (Q15);

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
       ListaTodasQuestoes.Add (Q16);

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
       ListaTodasQuestoes.Add (Q17);

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
       ListaTodasQuestoes.Add (Q18);

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
       ListaTodasQuestoes.Add (Q19);

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
       ListaTodasQuestoes.Add (Q20);

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
       ListaTodasQuestoes.Add(Q21);

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
       ListaTodasQuestoes.Add (Q22);

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
       ListaTodasQuestoes.Add (Q23);

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
       ListaTodasQuestoes.Add (Q24);

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
       ListaTodasQuestoes.Add (Q25);

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
       ListaTodasQuestoes.Add (Q26);

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
       ListaTodasQuestoes.Add (Q7);

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
       ListaTodasQuestoes.Add (Q28);

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
       ListaTodasQuestoes.Add (Q29);

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
       ListaTodasQuestoes.Add (Q30);

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
       ListaTodasQuestoes.Add (Q31);

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
       ListaTodasQuestoes.Add (Q32);

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
       ListaTodasQuestoes.Add (Q33);

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
       ListaTodasQuestoes.Add (Q34);

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
       ListaTodasQuestoes.Add (Q35);

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
       ListaTodasQuestoes.Add (Q36);

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
       ListaTodasQuestoes.Add (Q37);

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
       ListaTodasQuestoes.Add (Q38);

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
       ListaTodasQuestoes.Add (Q39);

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
       ListaTodasQuestoes.Add (Q40);

       var Q41= new Questao();
       Q41.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q41.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
       Q41.RespostaUm="1959";
       Q41.RespostaDois="1965";
       Q41.RespostaTres="1969";
       Q41.RespostaQuatro="1975";
       Q41.RespostaCinco="1980";
       Q41.RespostaCerta= 3;
       Q41.Nivel=1;
       ListaTodasQuestoes.Add(Q41);

       var Q42= new Questao();
       Q42.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q42.Pergunta = "Qual é a capital da França?";
       Q42.RespostaUm="Berlim";
       Q42.RespostaDois="Madri";
       Q42.RespostaTres="Roma";
       Q42.RespostaQuatro="Paris";
       Q42.RespostaCinco="Lisboa";
       Q42.RespostaCerta=4;
       Q42.Nivel=1;
       ListaTodasQuestoes.Add (Q42);

       var Q43= new Questao();
       Q43.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q43.Pergunta = "Qual é o elemento químico de número atômico 6?";
       Q43.RespostaUm=" Hidrogênio";
       Q43.RespostaDois=" Oxigênio";
       Q43.RespostaTres="Carbono";
       Q43.RespostaQuatro="Ferro";
       Q43.RespostaCinco="Nitrogênio";
       Q43.RespostaCerta=3;
       Q43.Nivel=1;
       ListaTodasQuestoes.Add (Q43);

       var Q44= new Questao();
       Q44.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q44.Pergunta = "Quem escreveu Dom Quixote?";
       Q44.RespostaUm="William Shakespeare";
       Q44.RespostaDois="Miguel de Cervantes";
       Q44.RespostaTres="Fernando Pessoa";
       Q44.RespostaQuatro="João Cabral de Melo Neto";
       Q44.RespostaCinco="Luís de Camões";
       Q44.RespostaCerta=2;
       Q44.Nivel=1;
       ListaTodasQuestoes.Add (Q44);

       var Q45= new Questao();
       Q45.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q45.Pergunta = "Qual é o maior planeta do sistema solar?";
       Q45.RespostaUm="Terra";
       Q45.RespostaDois="Marte";
       Q45.RespostaTres="Saturno";
       Q45.RespostaQuatro=" Júpiter";
       Q45.RespostaCinco="Vênus";
       Q45.RespostaCerta=4;
       Q45.Nivel=1;
       ListaTodasQuestoes.Add (Q45);

       var Q46= new Questao();
       Q46.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q46.Pergunta = "Qual é o símbolo químico da prata?";
       Q46.RespostaUm="Ag";
       Q46.RespostaDois="Au";
       Q46.RespostaTres="Pb";
       Q46.RespostaQuatro="Fe";
       Q46.RespostaCinco="Cu";
       Q46.RespostaCerta=1;
       Q46.Nivel=1;
       ListaTodasQuestoes.Add (Q46);

       var Q47= new Questao();
       Q47.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q47.Pergunta = "Quem pintou a obra Mona Lisa?";
       Q47.RespostaUm="Michelangelo";
       Q47.RespostaDois="Leonardo da Vinci";
       Q47.RespostaTres="Pablo Picasso";
       Q47.RespostaQuatro="Salvador Dalí";
       Q47.RespostaCinco="Vincent van Gogh";
       Q47.RespostaCerta=2;
       Q47.Nivel=1;
       ListaTodasQuestoes.Add (Q47);

       var Q48= new Questao();
       Q48.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q48.Pergunta = "Qual é o país mais populoso do mundo?";
       Q48.RespostaUm="Estados Unidos";
       Q48.RespostaDois="Índia";
       Q48.RespostaTres="China";
       Q48.RespostaQuatro="Rússia";
       Q48.RespostaCinco="Brasil";
       Q48.RespostaCerta=3;
       Q48.Nivel=1;
       ListaTodasQuestoes.Add (Q48);

       var Q49= new Questao();
       Q49.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q49.Pergunta = "Qual é a velocidade da luz no vácuo?";
       Q49.RespostaUm="150.000 km/s";
       Q49.RespostaDois="300.000 km/s";
       Q49.RespostaTres="450.000 km/s";
       Q49.RespostaQuatro="600.000 km/s";
       Q49.RespostaCinco="750.000 km/s";
       Q49.RespostaCerta=2;
       Q49.Nivel=1;
       ListaTodasQuestoes.Add (Q49);

       var Q50= new Questao();
       Q50.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q50.Pergunta = "Quem foi o primeiro presidente do Brasil?";
       Q50.RespostaUm="Getúlio Vargas";
       Q50.RespostaDois="Juscelino Kubitschek";
       Q50.RespostaTres=" Deodoro da Fonseca";
       Q50.RespostaQuatro="Floriano Peixoto";
       Q50.RespostaCinco="João Goulart";
       Q50.RespostaCerta=3;
       Q50.Nivel=1;
       ListaTodasQuestoes.Add (Q50);

       var Q51= new Questao();
       Q51.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q51.Pergunta = "Em qual continente está localizado o Egito?";
       Q51.RespostaUm="Ásia";
       Q51.RespostaDois=" África";
       Q51.RespostaTres="Europa";
       Q51.RespostaQuatro="América do Sul";
       Q51.RespostaCinco="Oceania";
       Q51.RespostaCerta=2;
       Q51.Nivel=1;
       ListaTodasQuestoes.Add (Q51);

       var Q52= new Questao();
       Q52.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q52.Pergunta = "Qual desses animais é um mamífero?";
       Q52.RespostaUm="Pinguim";
       Q52.RespostaDois="Tubarão";
       Q52.RespostaTres="Golfinho";
       Q52.RespostaQuatro="Jacaré";
       Q52.RespostaCinco="Salamandra";
       Q52.RespostaCerta=3;
       Q52.Nivel=1;
       ListaTodasQuestoes.Add (Q52);

       var Q53= new Questao();
       Q53.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q53.Pergunta = "Quantos estados existem no Brasil?";
       Q53.RespostaUm="26";
       Q53.RespostaDois="25";
       Q53.RespostaTres="27";
       Q53.RespostaQuatro="28";
       Q53.RespostaCinco="29";
       Q53.RespostaCerta=3;
       Q53.Nivel=1;
       ListaTodasQuestoes.Add (Q53);

       var Q54= new Questao();
       Q54.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q54.Pergunta = "Qual é o maior oceano do mundo?";
       Q54.RespostaUm=" Atlântico";
       Q54.RespostaDois=" Índico";
       Q54.RespostaTres="Ártico";
       Q54.RespostaQuatro="Pacífico";
       Q54.RespostaCinco="Antártico";
       Q54.RespostaCerta=4;
       Q54.Nivel=1;
       ListaTodasQuestoes.Add (Q54);

       var Q55= new Questao();
       Q55.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q55.Pergunta = "Qual é o órgão responsável pela circulação do sangue no corpo humano?";
       Q55.RespostaUm="Pulmão";
       Q55.RespostaDois="Estômago";
       Q55.RespostaTres="Rim";
       Q55.RespostaQuatro="Fígado";
       Q55.RespostaCinco="Coração";
       Q55.RespostaCerta=5;
       Q55.Nivel=1;
       ListaTodasQuestoes.Add (Q55);

       var Q56= new Questao();
       Q56.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q56.Pergunta = "Em que país se encontra a Torre Eiffel?";
       Q56.RespostaUm="Itália";
       Q56.RespostaDois="Espanha";
       Q56.RespostaTres="França";
       Q56.RespostaQuatro="Alemanha";
       Q56.RespostaCinco="Suíça";
       Q56.RespostaCerta=3;
       Q56.Nivel=1;
       ListaTodasQuestoes.Add (Q56);

       var Q57= new Questao();
       Q57.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q57.Pergunta = "Qual é a fórmula química da água?";
       Q57.RespostaUm="H2O";
       Q57.RespostaDois="CO2";
       Q57.RespostaTres="O2";
       Q57.RespostaQuatro="NaCl";
       Q57.RespostaCinco="CH4";
       Q57.RespostaCerta=1;
       Q57.Nivel=1;
       ListaTodasQuestoes.Add (Q57);

       var Q58= new Questao();
       Q58.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q58.Pergunta = "Quem foi o autor de O Pequeno Príncipe?";
       Q58.RespostaUm="J.K. Rowling";
       Q58.RespostaDois="Antoine de Saint-Exupéry";
       Q58.RespostaTres="George Orwell";
       Q58.RespostaQuatro="Mark Twain";
       Q58.RespostaCinco="Franz Kafka";
       Q58.RespostaCerta=2;
       Q58.Nivel=1;
       ListaTodasQuestoes.Add (Q58);

       var Q59= new Questao();
       Q59.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q59.Pergunta = "Em qual país nasceu o futebol moderno?";
       Q59.RespostaUm="Espanha";
       Q59.RespostaDois="Brasil";
       Q59.RespostaTres="Alemanha";
       Q59.RespostaQuatro="Inglaterra";
       Q59.RespostaCinco="Itália";
       Q59.RespostaCerta=4;
       Q59.Nivel=1;
       ListaTodasQuestoes.Add (Q59);

       var Q60= new Questao();
       Q60.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q60.Pergunta = "Qual é o menor país do mundo?";
       Q60.RespostaUm="Vaticano";
       Q60.RespostaDois="Mônaco";
       Q60.RespostaTres="San Marino";
       Q60.RespostaQuatro="Liechtenstein";
       Q60.RespostaCinco="Malta";
       Q60.RespostaCerta=1;
       Q60.Nivel=1;
       ListaTodasQuestoes.Add (Q60);

       var Q61= new Questao();
       Q61.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q61.Pergunta = "Qual é o maior deserto do mundo?";
       Q61.RespostaUm="Saara";
       Q61.RespostaDois="Gobi";
       Q61.RespostaTres="Kalahari";
       Q61.RespostaQuatro=" Atacama";
       Q61.RespostaCinco="Antártico";
       Q61.RespostaCerta= 5;
       Q61.Nivel=1;
       ListaTodasQuestoes.Add(Q61);

       var Q62= new Questao();
       Q62.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q62.Pergunta = "Qual é a maior floresta tropical do mundo?";
       Q62.RespostaUm="Floresta do Congo";
       Q62.RespostaDois="Floresta Amazônica";
       Q62.RespostaTres="Taiga";
       Q62.RespostaQuatro="Floresta Negra";
       Q62.RespostaCinco="Floresta da Birmânia";
       Q62.RespostaCerta=2;
       Q62.Nivel=1;
       ListaTodasQuestoes.Add (Q62);

       var Q63= new Questao();
       Q63.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q63.Pergunta = "Qual é o metal mais leve?";
       Q63.RespostaUm=" Ouro";
       Q63.RespostaDois=" Ferro";
       Q63.RespostaTres="Lítio";
       Q63.RespostaQuatro="Cobre";
       Q63.RespostaCinco="Alimínio";
       Q63.RespostaCerta=3;
       Q63.Nivel=1;
       ListaTodasQuestoes.Add (Q63);

       var Q64= new Questao();
       Q64.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q64.Pergunta = "Quem foi o fundador do Facebook?";
       Q64.RespostaUm=" Steve Jobs";
       Q64.RespostaDois=" Bill Gates";
       Q64.RespostaTres="Jeff Bezos";
       Q64.RespostaQuatro="Elon Musk";
       Q64.RespostaCinco="Mark Zuckerberg";
       Q64.RespostaCerta=5;
       Q64.Nivel=1;
       ListaTodasQuestoes.Add (Q64);

       var Q65= new Questao();
       Q65.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q65.Pergunta = "Qual foi o primeiro homem a orbitar a Terra?";
       Q65.RespostaUm="Neil Armstrong";
       Q65.RespostaDois="Yuri Gagarin";
       Q65.RespostaTres="Buzz Aldrin";
       Q65.RespostaQuatro="Buzz Aldrin";
       Q65.RespostaCinco="Alan Shepard";
       Q65.RespostaCerta=2;
       Q65.Nivel=1;
       ListaTodasQuestoes.Add (Q65);

       var Q66= new Questao();
       Q66.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q66.Pergunta = "Qual país é famoso pelos Alpes?";
       Q66.RespostaUm="França";
       Q66.RespostaDois="Suiça";
       Q66.RespostaTres="Itália";
       Q66.RespostaQuatro="Estados Unidos";
       Q66.RespostaCinco="Canadá";
       Q66.RespostaCerta=2;
       Q66.Nivel=1;
       ListaTodasQuestoes.Add (Q66);

       var Q67= new Questao();
       Q67.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q67.Pergunta = "Quem compôs a Nona Sinfonia?";
       Q67.RespostaUm="Wolfgang Amadeus Mozart";
       Q67.RespostaDois=" Ludwig van Beethoven";
       Q67.RespostaTres=" Johann Sebastian Bach";
       Q67.RespostaQuatro="Antonio Vivaldi";
       Q67.RespostaCinco="Richard Wagner";
       Q67.RespostaCerta=2;
       Q67.Nivel=1;
       ListaTodasQuestoes.Add (Q67);

       var Q68= new Questao();
       Q68.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q68.Pergunta = "Qual é o estado mais populoso do Brasil?";
       Q68.RespostaUm= "Rio de Janeiro";
       Q68.RespostaDois="Minas Gerais";
       Q68.RespostaTres="Bahia";
       Q68.RespostaQuatro="São Paulo";
       Q68.RespostaCinco="Paraná";
       Q68.RespostaCerta=4;
       Q68.Nivel=1;
       ListaTodasQuestoes.Add (Q68);

       var Q69= new Questao();
       Q69.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q69.Pergunta = "Qual desses filósofos é conhecido por sua obra A República?";
       Q69.RespostaUm="Aristóteles";
       Q69.RespostaDois="Sócrates";
       Q69.RespostaTres=" Platão";
       Q69.RespostaQuatro=" Descartes";
       Q69.RespostaCinco="Nietzsche";
       Q69.RespostaCerta=3;
       Q69.Nivel=1;
       ListaTodasQuestoes.Add (Q69);

       var Q70= new Questao();
       Q70.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q70.Pergunta = "Qual é o rio mais longo do mundo?";
       Q70.RespostaUm="Nilo";
       Q70.RespostaDois="Amazonas";
       Q70.RespostaTres="  Mississipi";
       Q70.RespostaQuatro="Yangtzé";
       Q70.RespostaCinco="Danúbio";
       Q70.RespostaCerta=1;
       Q70.Nivel=1;
       ListaTodasQuestoes.Add (Q70);

       var Q71= new Questao();
       Q71.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q71.Pergunta = "Quem pintou A Última Ceia?";
       Q71.RespostaUm=" Michelangelo";
       Q71.RespostaDois=" Leonardo da Vinci";
       Q71.RespostaTres="Pablo Picasso";
       Q71.RespostaQuatro="Salvador Dalí";
       Q71.RespostaCinco="Vincent van Gogh";
       Q71.RespostaCerta=2;
       Q71.Nivel=1;
       ListaTodasQuestoes.Add (Q71);

       var Q72= new Questao();
       Q72.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q72.Pergunta = " Qual é a montanha mais alta do mundo?";
       Q72.RespostaUm="Kilimanjaro";
       Q72.RespostaDois="K2";
       Q72.RespostaTres="Everest";
       Q72.RespostaQuatro=" Aconcágua";
       Q72.RespostaCinco=" Mont Blanc";
       Q72.RespostaCerta=3;
       Q72.Nivel=1;
       ListaTodasQuestoes.Add (Q72);

       var Q73= new Questao();
       Q73.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q73.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
       Q73.RespostaUm="Abraham Lincoln";
       Q73.RespostaDois=" Thomas Jefferson";
       Q73.RespostaTres=" George Washington";
       Q73.RespostaQuatro=" John Adams";
       Q73.RespostaCinco="Theodore Roosevelt";
       Q73.RespostaCerta=3;
       Q73.Nivel=1;
       ListaTodasQuestoes.Add (Q73);

       var Q74= new Questao();
       Q74.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q74.Pergunta = "Qual é a fórmula química do sal de cozinha?";
       Q74.RespostaUm=" H2SO4";
       Q74.RespostaDois=" NaCl";
       Q74.RespostaTres="KOH";
       Q74.RespostaQuatro=" C6H12O6";
       Q74.RespostaCinco="CO2";
       Q74.RespostaCerta=2;
       Q74.Nivel=1;
       ListaTodasQuestoes.Add (Q74);

       var Q75= new Questao();
       Q75.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q75.Pergunta = "Qual é a capital do Japão?";
       Q75.RespostaUm=" Seul";
       Q75.RespostaDois="Pequim";
       Q75.RespostaTres="Tóquio";
       Q75.RespostaQuatro="Bangkok";
       Q75.RespostaCinco="Xangai";
       Q75.RespostaCerta=3;
       Q75.Nivel=1;
       ListaTodasQuestoes.Add (Q75);

       var Q76= new Questao();
       Q76.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q76.Pergunta = "Quem foi o último faraó do Egito?";
       Q76.RespostaUm="Ramsés II";
       Q76.RespostaDois="Tutancâmon";
       Q76.RespostaTres="Akhenaton";
       Q76.RespostaQuatro="Cleópatra";
       Q76.RespostaCinco="Nefertiti";
       Q76.RespostaCerta=4;
       Q76.Nivel=1;
       ListaTodasQuestoes.Add (Q76);

       var Q77= new Questao();
       Q77.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q77.Pergunta = "Qual desses países faz parte da Escandinávia?";
       Q77.RespostaUm=" França";
       Q77.RespostaDois="Alemanha";
       Q77.RespostaTres="Dinamarca";
       Q77.RespostaQuatro="Rússia";
       Q77.RespostaCinco=" Polônia";
       Q77.RespostaCerta=3;
       Q77.Nivel=1;
       ListaTodasQuestoes.Add (Q77);

       var Q78= new Questao();
       Q78.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q78.Pergunta = "Qual é a cor da faixa do meio da bandeira da Itália?";
       Q78.RespostaUm="Vermelho";
       Q78.RespostaDois="Branco";
       Q78.RespostaTres="Verde";
       Q78.RespostaQuatro="Azul";
       Q78.RespostaCinco="Amarelo";
       Q78.RespostaCerta=2;
       Q78.Nivel=1;
       ListaTodasQuestoes.Add (Q78);

       var Q79= new Questao();
       Q79.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q79.Pergunta = "Qual é o instrumento musical típico da Escócia?";
       Q79.RespostaUm="Violino";
       Q79.RespostaDois="Harpa";
       Q79.RespostaTres="Guitarra";
       Q79.RespostaQuatro="Gaita de foles";
       Q79.RespostaCinco="Saxofone";
       Q79.RespostaCerta=4;
       Q79.Nivel=1;
       ListaTodasQuestoes.Add (Q79);

       var Q80= new Questao();
       Q80.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
       Q80.Pergunta = "Qual é a principal fonte de energia do sol?";
       Q80.RespostaUm="Fissão nuclear";
       Q80.RespostaDois="Combustão";
       Q80.RespostaTres="Reações químicas";
       Q80.RespostaQuatro="Fusões nucleares";
       Q80.RespostaCinco="Magnetismo";
       Q80.RespostaCerta=4;
       Q80.Nivel=1;
       ListaTodasQuestoes.Add (Q80);
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
        var listaQuestoes=ListaTodasQuestoes.Where (d=>d.Nivel==NivelAtual). ToList();
        var nAleat = Random.Shared.Next(0, listaQuestoes.Count-1);
        var novaQuestao= listaQuestoes [nAleat];
        while (ListaTodasQuestoesRespondidas.Contains(novaQuestao))
        {
            nAleat= Random.Shared.Next (0, listaQuestoes.Count-1);
            novaQuestao= listaQuestoes[nAleat];
        }
        ListaTodasQuestoesRespondidas.Add(novaQuestao);
        QuestaoCorrente = novaQuestao;
        QuestaoCorrente.Desenhar ();
       }

       void Inicializar()
       {
         Pontos=0;
         NivelAtual=1;
         ProximaQuestao();
         ListaTodasQuestoesRespondidas.Clear();
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
