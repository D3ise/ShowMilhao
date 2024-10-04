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
       Q11.Nivel=2;
       ListaTodasQuestoes.Add (Q11);

        var Q12 = new Questao();
        Q12.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q12.Pergunta = "Qual é a capital da Austrália?";
        Q12.RespostaUm = "Sydney";
        Q12.RespostaDois = "Canberra";
        Q12.RespostaTres = "Melbourne";
        Q12.RespostaQuatro = "Brisbane";
        Q12.RespostaCinco = "Perth";
        Q12.RespostaCerta = 2;
        Q12.Nivel = 2;
        ListaTodasQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q13.Pergunta = "Quem foi o primeiro a cruzar o Oceano Atlântico em voo solo?";
        Q13.RespostaUm = "Charles Lindbergh";
        Q13.RespostaDois = "Amelia Earhart";
        Q13.RespostaTres = "Wilbur Wright";
        Q13.RespostaQuatro = "Howard Hughes";
        Q13.RespostaCinco = "Bessie Coleman";
        Q13.RespostaCerta = 1;
        Q13.Nivel = 2;
        ListaTodasQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q14.Pergunta = "Qual é a montanha mais alta do mundo?";
        Q14.RespostaUm = "K2";
        Q14.RespostaDois = "Kangchenjunga";
        Q14.RespostaTres = "Everest";
        Q14.RespostaQuatro = "Lhotse";
        Q14.RespostaCinco = "Makalu";
        Q14.RespostaCerta = 3;
        Q14.Nivel = 2;
        ListaTodasQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q15.Pergunta = "Qual o nome do famoso físico que desenvolveu a teoria da relatividade?";
        Q15.RespostaUm = "Isaac Newton";
        Q15.RespostaDois = "Albert Einstein";
        Q15.RespostaTres = "Galileu Galilei";
        Q15.RespostaQuatro = "Stephen Hawking";
        Q15.RespostaCinco = "Niels Bohr";
        Q15.RespostaCerta = 2;
        Q15.Nivel = 2;
        ListaTodasQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q16.Pergunta = "Qual é a fórmula química do ozônio?";
        Q16.RespostaUm = "O2";
        Q16.RespostaDois = "O3";
        Q16.RespostaTres = "CO2";
        Q16.RespostaQuatro = "N2";
        Q16.RespostaCinco = "H2O";
        Q16.RespostaCerta = 2;
        Q16.Nivel = 2;
        ListaTodasQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q17.Pergunta = "Qual é o nome do maior deserto do mundo?";
        Q17.RespostaUm = "Deserto do Saara";
        Q17.RespostaDois = "Deserto de Gobi";
        Q17.RespostaTres = "Deserto da Antártida";
        Q17.RespostaQuatro = "Deserto de Kalahari";
        Q17.RespostaCinco = "Deserto de Atacama";
        Q17.RespostaCerta = 3;
        Q17.Nivel = 2;
        ListaTodasQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q18.Pergunta = "Quem foi o autor da obra 'A Divina Comédia'?";
        Q18.RespostaUm = "Fernando Pessoa";
        Q18.RespostaDois = "Dante Alighieri";
        Q18.RespostaTres = "William Shakespeare";
        Q18.RespostaQuatro = "Johann Wolfgang von Goethe";
        Q18.RespostaCinco = "Mark Twain";
        Q18.RespostaCerta = 2;
        Q18.Nivel = 2;
        ListaTodasQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q19.Pergunta = "Qual é a moeda oficial do Japão?";
        Q19.RespostaUm = "Yuan";
        Q19.RespostaDois = "Won";
        Q19.RespostaTres = "Dólar";
        Q19.RespostaQuatro = "Yen";
        Q19.RespostaCinco = "Rupia";
        Q19.RespostaCerta = 4;
        Q19.Nivel = 2;
        ListaTodasQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q20.Pergunta = "Qual a principal língua falada na Suécia?";
        Q20.RespostaUm = "Norueguês";
        Q20.RespostaDois = "Finlandês";
        Q20.RespostaTres = "Sueco";
        Q20.RespostaQuatro = "Dinamarquês";
        Q20.RespostaCinco = "Islandês";
        Q20.RespostaCerta = 3;
        Q20.Nivel = 2;
        ListaTodasQuestoes.Add(Q20);

        var Q21= new Questao();
        Q21.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q21.Pergunta = "Qual desses animais é um mamífero?";
        Q21.RespostaUm="Pinguim";
        Q21.RespostaDois="Tubarão";
        Q21.RespostaTres="Golfinho";
        Q21.RespostaQuatro="Jacaré";
        Q21.RespostaCinco="Salamandra";
        Q21.RespostaCerta=3;
        Q21.Nivel=3;
        ListaTodasQuestoes.Add (Q21);

        var Q22 = new Questao();
        Q22.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q22.Pergunta = "Qual é a capital do Nepal?";
        Q22.RespostaUm = "Kathmandu";
        Q22.RespostaDois = "Deli";
        Q22.RespostaTres = "Thimphu";
        Q22.RespostaQuatro = "Lhasa";
        Q22.RespostaCinco = "Bangcoc";
        Q22.RespostaCerta = 1;
        Q22.Nivel = 3;
        ListaTodasQuestoes.Add(Q22);

        var Q23 = new Questao();
        Q23.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q23.Pergunta = "Qual foi a primeira civilização a desenvolver a escrita?";
        Q23.RespostaUm = "Egípcios";
        Q23.RespostaDois = "Sumérios";
        Q23.RespostaTres = "Babilônios";
        Q23.RespostaQuatro = "Chineses";
        Q23.RespostaCinco = "Maya";
        Q23.RespostaCerta = 2;
        Q23.Nivel = 3;
        ListaTodasQuestoes.Add(Q23);

        var Q24 = new Questao();
        Q24.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q24.Pergunta = "Quem formulou as leis do movimento e a gravitação universal?";
        Q24.RespostaUm = "Galileu Galilei";
        Q24.RespostaDois = "Isaac Newton";
        Q24.RespostaTres = "Albert Einstein";
        Q24.RespostaQuatro = "Nikola Tesla";
        Q24.RespostaCinco = "James Clerk Maxwell";
        Q24.RespostaCerta = 2;
        Q24.Nivel = 3;
        ListaTodasQuestoes.Add(Q24);

        var Q25 = new Questao();
        Q25.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q25.Pergunta = "Qual é a obra mais famosa de Miguel de Cervantes?";
        Q25.RespostaUm = "Dom Quixote";
        Q25.RespostaDois = "Os Lusíadas";
        Q25.RespostaTres = "Hamlet";
        Q25.RespostaQuatro = "A Divina Comédia";
        Q25.RespostaCinco = "Orgulho e Preconceito";
        Q25.RespostaCerta = 1;
        Q25.Nivel = 3;
        ListaTodasQuestoes.Add(Q25);

        var Q26 = new Questao();
        Q26.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q26.Pergunta = "Qual é o principal gás do efeito estufa?";
        Q26.RespostaUm = "Dióxido de carbono (CO2)";
        Q26.RespostaDois = "Metano (CH4)";
        Q26.RespostaTres = "Óxido nitroso (N2O)";
        Q26.RespostaQuatro = "Vapor d'água";
        Q26.RespostaCinco = "Oxigênio (O2)";
        Q26.RespostaCerta = 1;
        Q26.Nivel = 3;
        ListaTodasQuestoes.Add(Q26);

        var Q27 = new Questao();
        Q27.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q27.Pergunta = "Qual é a única substância que pode existir nos três estados físicos naturais (sólido, líquido e gasoso) à temperatura e pressão ambientes?";
        Q27.RespostaUm = "Água";
        Q27.RespostaDois = "Dióxido de carbono";
        Q27.RespostaTres = "Oxigênio";
        Q27.RespostaQuatro = "Hélio";
        Q27.RespostaCinco = "Nitrogênio";
        Q27.RespostaCerta = 1;
        Q27.Nivel = 3;
        ListaTodasQuestoes.Add(Q27);

        var Q28 = new Questao();
        Q28.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q28.Pergunta = "Quem é conhecido como o 'pai da psicanálise'?";
        Q28.RespostaUm = "Carl Jung";
        Q28.RespostaDois = "Sigmund Freud";
        Q28.RespostaTres = "B.F. Skinner";
        Q28.RespostaQuatro = "Alfred Adler";
        Q28.RespostaCinco = "William James";
        Q28.RespostaCerta = 2;
        Q28.Nivel = 3;
        ListaTodasQuestoes.Add(Q28);

        var Q29 = new Questao();
        Q29.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q29.Pergunta = "Qual é a unidade básica da vida?";
        Q29.RespostaUm = "Tecido";
        Q29.RespostaDois = "Célula";
        Q29.RespostaTres = "Órgão";
        Q29.RespostaQuatro = "Sistema";
        Q29.RespostaCinco = "Organismo";
        Q29.RespostaCerta = 2;
        Q29.Nivel = 3;
        ListaTodasQuestoes.Add(Q29);

        var Q30 = new Questao();
        Q30.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q30.Pergunta = "Qual é o continente mais populoso do mundo?";
        Q30.RespostaUm = "África";
        Q30.RespostaDois = "América";
        Q30.RespostaTres = "Ásia";
        Q30.RespostaQuatro = "Europa";
        Q30.RespostaCinco = "Oceania";
        Q30.RespostaCerta = 3;
        Q30.Nivel = 3;
        ListaTodasQuestoes.Add(Q30);

        var Q31= new Questao();
        Q31.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q31.Pergunta = "Quantos estados existem no Brasil?";
        Q31.RespostaUm="26";
        Q31.RespostaDois="25";
        Q31.RespostaTres="27";
        Q31.RespostaQuatro="28";
        Q31.RespostaCinco="29";
        Q31.RespostaCerta=3;
        Q31.Nivel=4;
        ListaTodasQuestoes.Add (Q31);

        var Q32 = new Questao();
        Q32.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q32.Pergunta = "Qual é a capital da Armênia?";
        Q32.RespostaUm = "Yerevan";
        Q32.RespostaDois = "Baku";
        Q32.RespostaTres = "Tbilisi";
        Q32.RespostaQuatro = "Ankara";
        Q32.RespostaCinco = "Teerã";
        Q32.RespostaCerta = 1;
        Q32.Nivel = 4;
        ListaTodasQuestoes.Add(Q32);

        var Q33 = new Questao();
        Q33.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q33.Pergunta = "Quem foi o último imperador da Rússia?";
        Q33.RespostaUm = "Pedro II";
        Q33.RespostaDois = "Nicolau II";
        Q33.RespostaTres = "Alexandre III";
        Q33.RespostaQuatro = "Pedro I";
        Q33.RespostaCinco = "Nicolau I";
        Q33.RespostaCerta = 2;
        Q33.Nivel = 4;
        ListaTodasQuestoes.Add(Q33);

        var Q34 = new Questao();
        Q34.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q34.Pergunta = "Qual a capital da Mongólia?";
        Q34.RespostaUm = "Ulaanbaatar";
        Q34.RespostaDois = "Astana";
        Q34.RespostaTres = "Tóquio";
        Q34.RespostaQuatro = "Seul";
        Q34.RespostaCinco = "Pequim";
        Q34.RespostaCerta = 1;
        Q34.Nivel = 4;
        ListaTodasQuestoes.Add(Q34);

        var Q35 = new Questao();
        Q35.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q35.Pergunta = "Qual é o maior oceano do mundo?";
        Q35.RespostaUm = "Oceano Atlântico";
        Q35.RespostaDois = "Oceano Índico";
        Q35.RespostaTres = "Oceano Ártico";
        Q35.RespostaQuatro = "Oceano Pacífico";
        Q35.RespostaCinco = "Oceano Antártico";
        Q35.RespostaCerta = 4;
        Q35.Nivel = 4;
        ListaTodasQuestoes.Add(Q35);

        var Q36 = new Questao();
        Q36.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q36.Pergunta = "Qual é o sistema de governo da Suíça?";
        Q36.RespostaUm = "Monarquia";
        Q36.RespostaDois = "República Federal";
        Q36.RespostaTres = "Ditadura";
        Q36.RespostaQuatro = "República Parlamentar";
        Q36.RespostaCinco = "Teocracia";
        Q36.RespostaCerta = 2;
        Q36.Nivel = 4;
        ListaTodasQuestoes.Add(Q36);

        var Q37 = new Questao();
        Q37.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q37.Pergunta = "Quem pintou 'O Nascimento de Vênus'?";
        Q37.RespostaUm = "Michelangelo";
        Q37.RespostaDois = "Sandro Botticelli";
        Q37.RespostaTres = "Leonardo da Vinci";
        Q37.RespostaQuatro = "Raphael";
        Q37.RespostaCinco = "Caravaggio";
        Q37.RespostaCerta = 2;
        Q37.Nivel = 4;
        ListaTodasQuestoes.Add(Q37);

        var Q38 = new Questao();
        Q38.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q38.Pergunta = "Qual foi a primeira mulher a ganhar um Prêmio Nobel?";
        Q38.RespostaUm = "Marie Curie";
        Q38.RespostaDois = "Rosalind Franklin";
        Q38.RespostaTres = "Malala Yousafzai";
        Q38.RespostaQuatro = "Ada Lovelace";
        Q38.RespostaCinco = "Jane Goodall";
        Q38.RespostaCerta = 1;
        Q38.Nivel = 4;
        ListaTodasQuestoes.Add(Q38);

        var Q39 = new Questao();
        Q39.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q39.Pergunta = "Qual é a principal obra de Karl Marx?";
        Q39.RespostaUm = "A Riqueza das Nações";
        Q39.RespostaDois = "O Capital";
        Q39.RespostaTres = "A Origem das Espécies";
        Q39.RespostaQuatro = "O Príncipe";
        Q39.RespostaCinco = "A Ética";
        Q39.RespostaCerta = 2;
        Q39.Nivel = 4;
        ListaTodasQuestoes.Add(Q39);

        var Q40 = new Questao();
        Q40.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q40.Pergunta = "Qual é a fórmula da água destilada?";
        Q40.RespostaUm = "H2O2";
        Q40.RespostaDois = "H2O";
        Q40.RespostaTres = "O2";
        Q40.RespostaQuatro = "CO2";
        Q40.RespostaCinco = "NaCl";
        Q40.RespostaCerta = 2;
        Q40.Nivel = 4;
        ListaTodasQuestoes.Add(Q40);

        var Q41= new Questao();
        Q41.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q41.Pergunta = "Quem foi o autor de O Pequeno Príncipe?";
        Q41.RespostaUm="J.K. Rowling";
        Q41.RespostaDois="Antoine de Saint-Exupéry";
        Q41.RespostaTres="George Orwell";
        Q41.RespostaQuatro="Mark Twain";
        Q41.RespostaCinco="Franz Kafka";
        Q41.RespostaCerta=2;
        Q41.Nivel=5;
        ListaTodasQuestoes.Add (Q41);

        var Q52 = new Questao();
        Q52.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q52.Pergunta = "Qual é a obra mais famosa de Platão?";
        Q52.RespostaUm = "A República";
        Q52.RespostaDois = "Ética a Nicômaco";
        Q52.RespostaTres = "Meditations";
        Q52.RespostaQuatro = "Discurso do Método";
        Q52.RespostaCinco = "O Príncipe";
        Q52.RespostaCerta = 1;
        Q52.Nivel = 5;
        ListaTodasQuestoes.Add(Q52);

        var Q53 = new Questao();
        Q53.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q53.Pergunta = "Qual é o elemento químico mais abundante no universo?";
        Q53.RespostaUm = "Oxigênio";
        Q53.RespostaDois = "Hidrogênio";
        Q53.RespostaTres = "Carbono";
        Q53.RespostaQuatro = "Nitrogênio";
        Q53.RespostaCinco = "Hélio";
        Q53.RespostaCerta = 2;
        Q53.Nivel = 5;
        ListaTodasQuestoes.Add(Q53);

        var Q54 = new Questao();
        Q54.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q54.Pergunta = "Quem foi o autor da teoria da evolução?";
        Q54.RespostaUm = "Gregory Mendel";
        Q54.RespostaDois = "Charles Darwin";
        Q54.RespostaTres = "Jean-Baptiste Lamarck";
        Q54.RespostaQuatro = "Louis Pasteur";
        Q54.RespostaCinco = "Richard Dawkins";
        Q54.RespostaCerta = 2;
        Q54.Nivel = 5;
        ListaTodasQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q55.Pergunta = "Qual foi a primeira civilização a usar a escrita cuneiforme?";
        Q55.RespostaUm = "Babilônios";
        Q55.RespostaDois = "Sumérios";
        Q55.RespostaTres = "Egípcios";
        Q55.RespostaQuatro = "Fenícios";
        Q55.RespostaCinco = "Gregos";
        Q55.RespostaCerta = 2;
        Q55.Nivel = 5;
        ListaTodasQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q56.Pergunta = "Qual foi a primeira cidade a alcançar uma população de um milhão de habitantes?";
        Q56.RespostaUm = "Roma";
        Q56.RespostaDois = "Pequim";
        Q56.RespostaTres = "Bagdá";
        Q56.RespostaQuatro = "Nova York";
        Q56.RespostaCinco = "Londres";
        Q56.RespostaCerta = 1;
        Q56.Nivel = 5;
        ListaTodasQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q57.Pergunta = "Qual é a teoria que descreve a origem do universo?";
        Q57.RespostaUm = "Teoria do Big Bang";
        Q57.RespostaDois = "Teoria da Relatividade";
        Q57.RespostaTres = "Teoria da Evolução";
        Q57.RespostaQuatro = "Teoria do Caos";
        Q57.RespostaCinco = "Teoria da Gravitação";
        Q57.RespostaCerta = 1;
        Q57.Nivel = 5;
        ListaTodasQuestoes.Add(Q57);

        var Q58 = new Questao();
        Q58.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q58.Pergunta = "Qual foi a principal consequência da Revolução Industrial?";
        Q58.RespostaUm = "Aumento da população rural";
        Q58.RespostaDois = "Aumento da urbanização";
        Q58.RespostaTres = "Diminuição da produção em massa";
        Q58.RespostaQuatro = "Diminuição do comércio internacional";
        Q58.RespostaCinco = "Aumento da escravidão";
        Q58.RespostaCerta = 2;
        Q58.Nivel = 5;
        ListaTodasQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q59.Pergunta = "Quem é considerado o 'pai da história'?";
        Q59.RespostaUm = "Heródoto";
        Q59.RespostaDois = "Tucídides";
        Q59.RespostaTres = "Socrátes";
        Q59.RespostaQuatro = "Platão";
        Q59.RespostaCinco = "Aristóteles";
        Q59.RespostaCerta = 1;
        Q59.Nivel = 5;
        ListaTodasQuestoes.Add(Q59);

        var Q60 = new Questao();
        Q60.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q60.Pergunta = "Qual é o maior planeta do sistema solar?";
        Q60.RespostaUm = "Terra";
        Q60.RespostaDois = "Marte";
        Q60.RespostaTres = "Júpiter";
        Q60.RespostaQuatro = "Saturno";
        Q60.RespostaCinco = "Netuno";
        Q60.RespostaCerta = 3;
        Q60.Nivel = 5;
        ListaTodasQuestoes.Add(Q60);

        var Q61= new Questao();
        Q61.ConfigurarDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q61.Pergunta = "Em que país se encontra a Torre Eiffel?";
        Q61.RespostaUm="Itália";
        Q61.RespostaDois="Espanha";
        Q61.RespostaTres="França";
        Q61.RespostaQuatro="Alemanha";
        Q61.RespostaCinco="Suíça";
        Q61.RespostaCerta=3;
        Q61.Nivel=6;
        ListaTodasQuestoes.Add (Q61);

        var Q62 = new Questao();
        Q62.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q62.Pergunta = "Qual é a fórmula química do ácido sulfúrico?";
        Q62.RespostaUm = "H2SO4";
        Q62.RespostaDois = "H2CO3";
        Q62.RespostaTres = "HCl";
        Q62.RespostaQuatro = "HNO3";
        Q62.RespostaCinco = "NaOH";
        Q62.RespostaCerta = 1;
        Q62.Nivel = 6;
        ListaTodasQuestoes.Add(Q62);

        var Q63 = new Questao();
        Q63.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q63.Pergunta = "Qual é o teorema que relaciona os lados de um triângulo retângulo?";
        Q63.RespostaUm = "Teorema de Pitágoras";
        Q63.RespostaDois = "Teorema de Tales";
        Q63.RespostaTres = "Teorema de Euclides";
        Q63.RespostaQuatro = "Teorema de Descartes";
        Q63.RespostaCinco = "Teorema de Fermat";
        Q63.RespostaCerta = 1;
        Q63.Nivel = 6;
        ListaTodasQuestoes.Add(Q63);

        var Q64 = new Questao();
        Q64.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q64.Pergunta = "Qual é a principal obra de Sigmund Freud?";
        Q64.RespostaUm = "A Interpretação dos Sonhos";
        Q64.RespostaDois = "O Capital";
        Q64.RespostaTres = "O Príncipe";
        Q64.RespostaQuatro = "Assim Falou Zaratustra";
        Q64.RespostaCinco = "A Ética";
        Q64.RespostaCerta = 1;
        Q64.Nivel = 6;
        ListaTodasQuestoes.Add(Q64);

        var Q65 = new Questao();
        Q65.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q65.Pergunta = "Qual é o princípio da incerteza de Heisenberg relacionado?";
        Q65.RespostaUm = "Partículas subatômicas";
        Q65.RespostaDois = "Teoria da relatividade";
        Q65.RespostaTres = "Termodinâmica";
        Q65.RespostaQuatro = "Gravitação";
        Q65.RespostaCinco = "Eletromagnetismo";
        Q65.RespostaCerta = 1;
        Q65.Nivel = 6;
        ListaTodasQuestoes.Add(Q65);

        var Q66 = new Questao();
        Q66.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q66.Pergunta = "Quem escreveu 'A Divina Comédia'?";
        Q66.RespostaUm = "Virgílio";
        Q66.RespostaDois = "Dante Alighieri";
        Q66.RespostaTres = "Petrarca";
        Q66.RespostaQuatro = "Boccaccio";
        Q66.RespostaCinco = "Tasso";
        Q66.RespostaCerta = 2;
        Q66.Nivel = 6;
        ListaTodasQuestoes.Add(Q66);

        var Q67 = new Questao();
        Q67.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q67.Pergunta = "Qual é a unidade de medida da resistência elétrica?";
        Q67.RespostaUm = "Ohm";
        Q67.RespostaDois = "Volt";
        Q67.RespostaTres = "Ampere";
        Q67.RespostaQuatro = "Watt";
        Q67.RespostaCinco = "Coulomb";
        Q67.RespostaCerta = 1;
        Q67.Nivel = 6;
        ListaTodasQuestoes.Add(Q67);

        var Q68 = new Questao();
        Q68.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q68.Pergunta = "Qual é a obra mais conhecida de Friedrich Nietzsche?";
        Q68.RespostaUm = "Assim Falou Zaratustra";
        Q68.RespostaDois = "Além do Bem e do Mal";
        Q68.RespostaTres = "A Genealogia da Moral";
        Q68.RespostaQuatro = "Ecce Homo";
        Q68.RespostaCinco = "O Anticristo";
        Q68.RespostaCerta = 1;
        Q68.Nivel = 6;
        ListaTodasQuestoes.Add(Q68);

        var Q69 = new Questao();
        Q69.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q69.Pergunta = "Qual é a partícula subatômica com carga negativa?";
        Q69.RespostaUm = "Próton";
        Q69.RespostaDois = "Nêutron";
        Q69.RespostaTres = "Elétron";
        Q69.RespostaQuatro = "Quark";
        Q69.RespostaCinco = "Fóton";
        Q69.RespostaCerta = 3;
        Q69.Nivel = 6;
        ListaTodasQuestoes.Add(Q69);

        var Q70 = new Questao();
        Q70.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q70.Pergunta = "Qual é a lei que descreve a conservação da energia?";
        Q70.RespostaUm = "Lei de Ohm";
        Q70.RespostaDois = "Lei da Termodinâmica";
        Q70.RespostaTres = "Lei da Gravitação Universal";
        Q70.RespostaQuatro = "Lei da Conservação da Massa";
        Q70.RespostaCinco = "Lei da Conservação da Energia";
        Q70.RespostaCerta = 5;
        Q70.Nivel = 6;
        ListaTodasQuestoes.Add(Q70);

        var Q71= new Questao();
        Q71.ConfigurarDesenho ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q71.Pergunta = "Qual é a fórmula química da água?";
        Q71.RespostaUm="H2O";
        Q71.RespostaDois="CO2";
        Q71.RespostaTres="O2";
        Q71.RespostaQuatro="NaCl";
        Q71.RespostaCinco="CH4";
        Q71.RespostaCerta=1;
        Q71.Nivel=7;
        ListaTodasQuestoes.Add (Q71);

        var Q72 = new Questao();
        Q72.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q72.Pergunta = "Qual é o princípio da relatividade restrita de Einstein?";
        Q72.RespostaUm = "A velocidade da luz é constante em todos os referenciais.";
        Q72.RespostaDois = "O tempo é absoluto.";
        Q72.RespostaTres = "A gravidade é uma força de ação à distância.";
        Q72.RespostaQuatro = "O espaço é tridimensional.";
        Q72.RespostaCinco = "A matéria é indestrutível.";
        Q72.RespostaCerta = 1;
        Q72.Nivel = 7;
        ListaTodasQuestoes.Add(Q72);

        var Q73 = new Questao();
        Q73.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q73.Pergunta = "Quem formulou a teoria da evolução por seleção natural?";
        Q73.RespostaUm = "Charles Darwin";
        Q73.RespostaDois = "Jean-Baptiste Lamarck";
        Q73.RespostaTres = "Gregor Mendel";
        Q73.RespostaQuatro = "Richard Dawkins";
        Q73.RespostaCinco = "Alfred Russel Wallace";
        Q73.RespostaCerta = 1;
        Q73.Nivel = 7;
        ListaTodasQuestoes.Add(Q73);

        var Q74 = new Questao();
        Q74.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q74.Pergunta = "Qual é a principal obra de Immanuel Kant?";
        Q74.RespostaUm = "A Crítica da Razão Pura";
        Q74.RespostaDois = "A Ética a Nicômaco";
        Q74.RespostaTres = "O Contrato Social";
        Q74.RespostaQuatro = "A República";
        Q74.RespostaCinco = "O Príncipe";
        Q74.RespostaCerta = 1;
        Q74.Nivel = 7;
        ListaTodasQuestoes.Add(Q74);

        var Q75 = new Questao();
        Q75.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q75.Pergunta = "Qual é a principal característica das partículas subatômicas chamadas quarks?";
        Q75.RespostaUm = "Elétricos.";
        Q75.RespostaDois = "Têm massa.";
        Q75.RespostaTres = "Formam prótons e nêutrons.";
        Q75.RespostaQuatro = "Possuem spin.";
        Q75.RespostaCinco = "Todas as anteriores.";
        Q75.RespostaCerta = 5;
        Q75.Nivel = 7;
        ListaTodasQuestoes.Add(Q75);

        var Q76 = new Questao();
        Q76.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q76.Pergunta = "Qual é o conceito central da teoria do caos?";
        Q76.RespostaUm = "Determinismo absoluto.";
        Q76.RespostaDois = "Pequenas mudanças podem ter grandes consequências.";
        Q76.RespostaTres = "Sistemas lineares são previsíveis.";
        Q76.RespostaQuatro = "Sistemas não interativos.";
        Q76.RespostaCinco = "A estabilidade é a norma.";
        Q76.RespostaCerta = 2;
        Q76.Nivel = 7;
        ListaTodasQuestoes.Add(Q76);

        var Q77 = new Questao();
        Q77.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q77.Pergunta = "Qual foi a primeira civilização a desenvolver a escrita?";
        Q77.RespostaUm = "Sumérios";
        Q77.RespostaDois = "Egípcios";
        Q77.RespostaTres = "Fenícios";
        Q77.RespostaQuatro = "Babilônios";
        Q77.RespostaCinco = "Chineses";
        Q77.RespostaCerta = 1;
        Q77.Nivel = 7;
        ListaTodasQuestoes.Add(Q77);

        var Q78 = new Questao();
        Q78.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q8.Pergunta = "Qual é a obra de arte mais famosa de Leonardo da Vinci?";
        Q78.RespostaUm = "A Última Ceia";
        Q78.RespostaDois = "Mona Lisa";
        Q78.RespostaTres = "A Criação de Adão";
        Q78.RespostaQuatro = "O Nascimento de Vênus";
        Q78.RespostaCinco = "A Escola de Atenas";
        Q78.RespostaCerta = 2;
        Q78.Nivel = 7;
        ListaTodasQuestoes.Add(Q78);

        var Q79 = new Questao();
        Q79.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q79.Pergunta = "Qual é o princípio fundamental da mecânica quântica?";
        Q79.RespostaUm = "O determinismo é absoluto.";
        Q79.RespostaDois = "Partículas podem existir em múltiplos estados ao mesmo tempo.";
        Q79.RespostaTres = "A energia é sempre conservada.";
        Q79.RespostaQuatro = "A luz é sempre uma onda.";
        Q79.RespostaCinco = "O espaço é infinito.";
        Q79.RespostaCerta = 2;
        Q79.Nivel = 7;
        ListaTodasQuestoes.Add(Q79);

        var Q80 = new Questao();
        Q80.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q80.Pergunta = "Quem é conhecido como o 'pai da história moderna'?";
        Q80.RespostaUm = "Tucídides";
        Q80.RespostaDois = "Heródoto";
        Q80.RespostaTres = "Leopold von Ranke";
        Q80.RespostaQuatro = "Edward Gibbon";
        Q80.RespostaCinco = "Karl Marx";
        Q80.RespostaCerta = 3;
        Q80.Nivel = 7;
        ListaTodasQuestoes.Add(Q80);

        var Q81 = new Questao();
        Q81.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q81.Pergunta = "Qual é a equação de Einstein para a equivalência massa-energia?";
        Q81.RespostaUm = "E = mc^2";
        Q81.RespostaDois = "F = ma";
        Q81.RespostaTres = "E = hf";
        Q81.RespostaQuatro = "pV = nRT";
        Q81.RespostaCinco = "a = Δv/Δt";
        Q81.RespostaCerta = 1;
        Q81.Nivel = 8;
        ListaTodasQuestoes.Add(Q81);

        var Q82 = new Questao();
        Q82.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q82.Pergunta = "Quem desenvolveu a teoria das cordas?";
        Q82.RespostaUm = "Albert Einstein";
        Q82.RespostaDois = "Stephen Hawking";
        Q82.RespostaTres = "Brian Greene";
        Q82.RespostaQuatro = "Niels Bohr";
        Q82.RespostaCinco = "Richard Feynman";
        Q82.RespostaCerta = 3;
        Q82.Nivel = 8;
        ListaTodasQuestoes.Add(Q82);

        var Q83 = new Questao();
        Q83.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q83.Pergunta = "Qual é a principal obra de Karl Marx?";
        Q83.RespostaUm = "O Capital";
        Q83.RespostaDois = "A Ideologia Alemã";
        Q83.RespostaTres = "O Manifesto Comunista";
        Q83.RespostaQuatro = "Crítica da Economia Política";
        Q83.RespostaCinco = "A Luta de Classes na França";
        Q83.RespostaCerta = 1;
        Q83.Nivel = 8;
        ListaTodasQuestoes.Add(Q83);

        var Q84 = new Questao();
        Q84.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q84.Pergunta = "Qual é o teorema que estabelece que a soma dos ângulos internos de um triângulo é 180 graus?";
        Q84.RespostaUm = "Teorema de Pitágoras";
        Q84.RespostaDois = "Teorema da Semelhança";
        Q84.RespostaTres = "Teorema dos Ângulos Externos";
        Q84.RespostaQuatro = "Teorema da Soma dos Ângulos";
        Q84.RespostaCinco = "Teorema de Tales";
        Q84.RespostaCerta = 4;
        Q84.Nivel = 8;
        ListaTodasQuestoes.Add(Q84);

        var Q85 = new Questao();
        Q85.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q85.Pergunta = "Qual é o principal resultado da Revolução Francesa?";
        Q85.RespostaUm = "Absolutismo";
        Q85.RespostaDois = "Declaração dos Direitos do Homem e do Cidadão";
        Q85.RespostaTres = "Independência dos Estados Unidos";
        Q85.RespostaQuatro = "Imperialismo";
        Q85.RespostaCinco = "Primavera dos Povos";
        Q85.RespostaCerta = 2;
        Q85.Nivel = 8;
        ListaTodasQuestoes.Add(Q85);

        var Q86 = new Questao();
        Q86.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q86.Pergunta = "Qual é o conceito que descreve a transformação de um elemento químico em outro?";
        Q86.RespostaUm = "Reação Química";
        Q86.RespostaDois = "Fusão Nuclear";
        Q86.RespostaTres = "Transmutação";
        Q86.RespostaQuatro = "Fissão Nuclear";
        Q86.RespostaCinco = "Equilíbrio Químico";
        Q86.RespostaCerta = 3;
        Q86.Nivel = 8;
        ListaTodasQuestoes.Add(Q86);

        var Q87 = new Questao();
        Q87.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q87.Pergunta = "Qual é o principal sistema político descrito na obra 'O Príncipe' de Maquiavel?";
        Q87.RespostaUm = "Democracia";
        Q87.RespostaDois = "Tirania";
        Q87.RespostaTres = "Monarquia Absoluta";
        Q87.RespostaQuatro = "Republicanismo";
        Q87.RespostaCinco = "Autocracia";
        Q87.RespostaCerta = 5;
        Q87.Nivel = 8;
        ListaTodasQuestoes.Add(Q87);

        var Q88 = new Questao();
        Q88.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q88.Pergunta = "Qual é o princípio da termodinâmica que afirma que a energia não pode ser criada nem destruída?";
        Q88.RespostaUm = "Primeira Lei da Termodinâmica";
        Q88.RespostaDois = "Segunda Lei da Termodinâmica";
        Q88.RespostaTres = "Terceira Lei da Termodinâmica";
        Q88.RespostaQuatro = "Lei da Conservação da Energia";
        Q88.RespostaCinco = "Teorema de Carnot";
        Q88.RespostaCerta = 1;
        Q88.Nivel = 8;
        ListaTodasQuestoes.Add(Q88);

        var Q89 = new Questao();
        Q89.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q89.Pergunta = "Quem foi o primeiro homem a viajar no espaço?";
        Q89.RespostaUm = "Neil Armstrong";
        Q89.RespostaDois = "Yuri Gagarin";
        Q89.RespostaTres = "Buzz Aldrin";
        Q89.RespostaQuatro = "John Glenn";
        Q89.RespostaCinco = "Valentina Tereshkova";
        Q89.RespostaCerta = 2;
        Q89.Nivel = 8;
        ListaTodasQuestoes.Add(Q89);

        var Q90 = new Questao();
        Q90.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q90.Pergunta = "Qual é o teorema fundamental da álgebra?";
        Q90.RespostaUm = "Todo polinômio de grau n possui n raízes.";
        Q90.RespostaDois = "Todo número real pode ser fatorado.";
        Q90.RespostaTres = "Todo polinômio é divisível por seu grau.";
        Q90.RespostaQuatro = "A soma das raízes é igual ao coeficiente.";
        Q90.RespostaCinco = "Os números primos são infinitos.";
        Q90.RespostaCerta = 1;
        Q90.Nivel = 9;
        ListaTodasQuestoes.Add(Q90);

        var Q91 = new Questao();
        Q91.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q91.Pergunta = "Qual é o princípio de funcionamento da mecânica quântica?";
        Q91.RespostaUm = "A partícula tem uma trajetória definida.";
        Q91.RespostaDois = "As partículas podem existir em múltiplos estados.";
        Q91.RespostaTres = "A energia é contínua.";
        Q91.RespostaQuatro = "A luz é sempre uma onda.";
        Q91.RespostaCinco = "Sistemas isolados sempre alcançam o equilíbrio.";
        Q91.RespostaCerta = 2;
        Q91.Nivel = 9;
        ListaTodasQuestoes.Add(Q91);

        var Q92 = new Questao();
        Q92.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q92.Pergunta = "Quem propôs a hipótese da Terra como um sistema auto-regulável?";
        Q92.RespostaUm = "James Lovelock";
        Q92.RespostaDois = "Carl Sagan";
        Q92.RespostaTres = "David Suzuki";
        Q92.RespostaQuatro = "Alfred Wallace";
        Q92.RespostaCinco = "Charles Darwin";
        Q92.RespostaCerta = 1;
        Q92.Nivel = 9;
        ListaTodasQuestoes.Add(Q92);

        var Q93 = new Questao();
        Q93.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q93.Pergunta = "Qual é a principal diferença entre a relatividade restrita e a relatividade geral?";
        Q93.RespostaUm = "A restrita considera a gravidade.";
        Q93.RespostaDois = "A geral lida com a gravidade e a curvatura do espaço-tempo.";
        Q93.RespostaTres = "A restrita é aplicável apenas a corpos em movimento uniforme.";
        Q93.RespostaQuatro = "A geral é uma teoria de partículas.";
        Q93.RespostaCinco = "Ambas tratam do mesmo fenômeno.";
        Q93.RespostaCerta = 2;
        Q93.Nivel = 9;
        ListaTodasQuestoes.Add(Q93);

        var Q94 = new Questao();
        Q94.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q94.Pergunta = "Qual é o efeito que causa a mudança na cor da luz quando um objeto se move em direção ou para longe de um observador?";
        Q94.RespostaUm = "Efeito Doppler";
        Q94.RespostaDois = "Efeito fotoelétrico";
        Q94.RespostaTres = "Efeito Compton";
        Q94.RespostaQuatro = "Refração";
        Q94.RespostaCinco = "Interferência";
        Q94.RespostaCerta = 1;
        Q94.Nivel = 9;
        ListaTodasQuestoes.Add(Q94);

        var Q95 = new Questao();
        Q95.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q95.Pergunta = "Quem é considerado o pai da genética moderna?";
        Q95.RespostaUm = "Gregor Mendel";
        Q95.RespostaDois = "Charles Darwin";
        Q95.RespostaTres = "James Watson";
        Q95.RespostaQuatro = "Francis Crick";
        Q95.RespostaCinco = "Thomas Morgan";
        Q95.RespostaCerta = 1;
        Q95.Nivel = 9;
        ListaTodasQuestoes.Add(Q95);

        var Q96 = new Questao();
        Q96.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q96.Pergunta = "Qual é a teoria que descreve o desenvolvimento das espécies como resultado da seleção natural?";
        Q96.RespostaUm = "Teoria da Evolução";
        Q96.RespostaDois = "Teoria do Criação";
        Q96.RespostaTres = "Teoria da Catástrofe";
        Q96.RespostaQuatro = "Teoria da Espiral";
        Q96.RespostaCinco = "Teoria da Diversidade";
        Q96.RespostaCerta = 1;
        Q96.Nivel = 9;
        ListaTodasQuestoes.Add(Q96);

        var Q97 = new Questao();
        Q97.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q97.Pergunta = "Qual é a função do DNA na célula?";
        Q97.RespostaUm = "Armazenar informações genéticas.";
        Q97.RespostaDois = "Produzir energia.";
        Q97.RespostaTres = "Realizar a fotossíntese.";
        Q97.RespostaQuatro = "Transportar oxigênio.";
        Q97.RespostaCinco = "Dividir células.";
        Q97.RespostaCerta = 1;
        Q97.Nivel = 9;
        ListaTodasQuestoes.Add(Q97);

        var Q98 = new Questao();
        Q98.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q98.Pergunta = "Quem foi o autor do livro '1984', uma crítica ao totalitarismo?";
        Q98.RespostaUm = "Aldous Huxley";
        Q98.RespostaDois = "George Orwell";
        Q98.RespostaTres = "Ray Bradbury";
        Q98.RespostaQuatro = "Fahrenheit 451";
        Q98.RespostaCinco = "Margaret Atwood";
        Q98.RespostaCerta = 2;
        Q98.Nivel = 9;
        ListaTodasQuestoes.Add(Q98);

        var Q99 = new Questao();
        Q99.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q99.Pergunta = "Qual é o conceito que define a existência de múltiplos universos?";
        Q99.RespostaUm = "Teoria das Cordas";
        Q99.RespostaDois = "Multiverso";
        Q99.RespostaTres = "Big Bang";
        Q99.RespostaQuatro = "Teoria do Caos";
        Q99.RespostaCinco = "Efeito Observador";
        Q99.RespostaCerta = 2;
        Q99.Nivel = 10;
        ListaTodasQuestoes.Add(Q99);

        var Q100 = new Questao();
        Q100.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q100.Pergunta = "Qual é o princípio da incerteza de Heisenberg?";
        Q100.RespostaUm = "É impossível conhecer simultaneamente a posição e a velocidade de uma partícula.";
        Q100.RespostaDois = "A energia total de um sistema é constante.";
        Q100.RespostaTres = "As partículas não podem existir sem um observador.";
        Q100.RespostaQuatro = "A luz é tanto onda quanto partícula.";
        Q100.RespostaCinco = "A temperatura e a pressão são inversamente proporcionais.";
        Q100.RespostaCerta = 1;
        Q100.Nivel = 10;
        ListaTodasQuestoes.Add(Q100);

        var Q101 = new Questao();
        Q101.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q101.Pergunta = "Quem é conhecido por desenvolver a teoria da relatividade geral?";
        Q101.RespostaUm = "Isaac Newton";
        Q101.RespostaDois = "Albert Einstein";
        Q101.RespostaTres = "Niels Bohr";
        Q101.RespostaQuatro = "Galileu Galilei";
        Q101.RespostaCinco = "Stephen Hawking";
        Q101.RespostaCerta = 2;
        Q101.Nivel = 10;
        ListaTodasQuestoes.Add(Q101);

        var Q102 = new Questao();
        Q102.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q102.Pergunta = "Qual é a unidade básica da hereditariedade?";
        Q102.RespostaUm = "Célula";
        Q102.RespostaDois = "RNA";
        Q102.RespostaTres = "DNA";
        Q102.RespostaQuatro = "Proteína";
        Q102.RespostaCinco = "Carboidrato";
        Q102.RespostaCerta = 3;
        Q102.Nivel = 10;
        ListaTodasQuestoes.Add(Q102);

        var Q103 = new Questao();
        Q103.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q103.Pergunta = "Qual é o fenômeno que explica a expansão do universo?";
        Q103.RespostaUm = "Teoria da Relatividade";
        Q103.RespostaDois = "Teoria do Big Bang";
        Q103.RespostaTres = "Teoria da Evolução";
        Q103.RespostaQuatro = "Teoria da Gravitação";
        Q103.RespostaCinco = "Teoria do Caos";
        Q103.RespostaCerta = 2;
        Q103.Nivel = 10;
        ListaTodasQuestoes.Add(Q103);

        var Q104 = new Questao();
        Q104.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q104.Pergunta = "Qual é a fórmula da Lei de Moore?";
        Q104.RespostaUm = "O número de transistores em um chip dobra a cada dois anos.";
        Q104.RespostaDois = "A velocidade da luz é constante.";
        Q104.RespostaTres = "A energia é igual à massa vezes a velocidade da luz ao quadrado.";
        Q104.RespostaQuatro = "A resistência de um circuito é inversamente proporcional à corrente.";
        Q104.RespostaCinco = "A carga elétrica é sempre conservada.";
        Q104.RespostaCerta = 1;
        Q104.Nivel = 10;
        ListaTodasQuestoes.Add(Q104);

        var Q105 = new Questao();
        Q105.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q105.Pergunta = "Quem formulou a Teoria da Evolução pela Seleção Natural?";
        Q105.RespostaUm = "Charles Darwin";
        Q105.RespostaDois = "Jean-Baptiste Lamarck";
        Q105.RespostaTres = "Richard Dawkins";
        Q105.RespostaQuatro = "Greg Mendel";
        Q105.RespostaCinco = "Alfred Russel Wallace";
        Q105.RespostaCerta = 1;
        Q105.Nivel = 10;
        ListaTodasQuestoes.Add(Q105);

        var Q106 = new Questao();
        Q106.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q106.Pergunta = "Qual é a forma de energia que não pode ser criada ou destruída?";
        Q106.RespostaUm = "Energia Cinética";
        Q106.RespostaDois = "Energia Potencial";
        Q106.RespostaTres = "Energia Solar";
        Q106.RespostaQuatro = "Energia Térmica";
        Q106.RespostaCinco = "Energia Total";
        Q106.RespostaCerta = 5;
        Q106.Nivel = 10;
        ListaTodasQuestoes.Add(Q106);

        var Q107 = new Questao();
        Q107.ConfigurarDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q107.Pergunta = "Qual é a contribuição de Nikola Tesla para a eletricidade?";
        Q107.RespostaUm = "Desenvolvimento da corrente contínua.";
        Q107.RespostaDois = "Criação da corrente alternada.";
        Q107.RespostaTres = "Invenção da bateria.";
        Q107.RespostaQuatro = "Descoberta do eletromagnetismo.";
        Q107.RespostaCinco = "Desenvolvimento do gerador.";
        Q107.RespostaCerta = 2;
        Q107.Nivel = 10;
        ListaTodasQuestoes.Add(Q107);
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

       public void ProximaQuestao()
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
         labelPontuacao.Text="Pontuação:" + Pontos.ToString();
         labelNivel.Text="Nivel:" + NivelAtual.ToString();
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

       public Questao GetQuestaoCorrente()
       {
        return QuestaoCorrente;
       }
 

 }

}
