namespace QuizJogo;

public class Gerenciador
{
    public int Pontuacao { get; private set; }
    int NivelAtual = 1;
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoAtual;
    Label LabelPont;
    Label LabelNivel;

    public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05, Label labelPont, Label labelNivel)
    {
        LabelPont = labelPont;
        LabelNivel = labelNivel;
        CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    }

    void CriaPerguntas(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
    {
        var Q1 = new Questao();
        Q1.nivelpergunta = 1;
        Q1.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q1.pergunta = "Quem é o maior artilheiro da história da Seleção Brasileira?";
        Q1.resposta1 = "Neymar";
        Q1.resposta2 = "Ronaldo";
        Q1.resposta3 = "Bebeto";
        Q1.resposta4 = "Pele";
        Q1.resposta5 = "Ribamar";
        Q1.respostacorreta = 04;
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.nivelpergunta = 1;
        Q2.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q2.pergunta = "Qual é o estádio mais famoso do Brasil?";
        Q2.resposta1 = "Vila Belmiro";
        Q2.resposta2 = "Maracanã";
        Q2.resposta3 = "Morumbi";
        Q2.resposta4 = "Minerão";
        Q2.resposta5 = "Engenhão";
        Q2.respostacorreta = 02;
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.nivelpergunta = 1;
        Q3.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q3.pergunta = "Qual time não tem mundial?";
        Q3.resposta1 = "Santos";
        Q3.resposta2 = "Internacional";
        Q3.resposta3 = "Corinthians";
        Q3.resposta4 = "Palmeiras";
        Q3.resposta5 = "Flamengo";
        Q3.respostacorreta = 04;
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.nivelpergunta = 1;
        Q4.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q4.pergunta = "Qual time é bambi?";
        Q4.resposta1 = "Santos";
        Q4.resposta2 = "Internacional";
        Q4.resposta3 = "São Paulo";
        Q4.resposta4 = "Palmeiras";
        Q4.resposta5 = "Flamengo";
        Q4.respostacorreta = 03;
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.nivelpergunta = 1;
        Q5.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q5.pergunta = "Qual jogador brasileiro tem mais títulos da Champions League?";
        Q5.resposta1 = "Cafu";
        Q5.resposta2 = "Roberto Carlos";
        Q5.resposta3 = "Rivaldo";
        Q5.resposta4 = "Marcelo";
        Q5.resposta5 = "Neymar";
        Q5.respostacorreta = 4;
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.nivelpergunta = 1;
        Q6.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q6.pergunta = "Quantas Copas do Mundo a Seleção Brasileira venceu?";
        Q6.resposta1 = "3";
        Q6.resposta2 = "4";
        Q6.resposta3 = "5";
        Q6.resposta4 = "6";
        Q6.resposta5 = "2";
        Q6.respostacorreta = 3;
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.nivelpergunta = 1;
        Q7.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q7.pergunta = "Qual é o nome do maior rival do Palmeiras?";
        Q7.resposta1 = "Santos";
        Q7.resposta2 = "São Paulo";
        Q7.resposta3 = "Corinthians";
        Q7.resposta4 = "Fluminense";
        Q7.resposta5 = "Vasco";
        Q7.respostacorreta = 3;
        ListaQuestoes.Add(Q7);

        var Q9 = new Questao();
        Q9.nivelpergunta = 1;
        Q9.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q9.pergunta = "Qual jogador é conhecido como o 'Fenômeno'?";
        Q9.resposta1 = "Ronaldo";
        Q9.resposta2 = "Romário";
        Q9.resposta3 = "Neymar";
        Q9.resposta4 = "Pelé";
        Q9.resposta5 = "Zico";
        Q9.respostacorreta = 1;
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.nivelpergunta = 1;
        Q10.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q10.pergunta = "Qual time é conhecido como o 'Peixe'?";
        Q10.resposta1 = "Vasco";
        Q10.resposta2 = "Flamengo";
        Q10.resposta3 = "São Paulo";
        Q10.resposta4 = "Santos";
        Q10.resposta5 = "Corinthians";
        Q10.respostacorreta = 4;
        ListaQuestoes.Add(Q10);

        var Q11 = new Questao();
        Q11.nivelpergunta = 1;
        Q11.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q11.pergunta = "Quem é o jogador brasileiro com mais partidas pela Seleção?";
        Q11.resposta1 = "Cafu";
        Q11.resposta2 = "Dunga";
        Q11.resposta3 = "Neymar";
        Q11.resposta4 = "Ronaldo";
        Q11.resposta5 = "Thiago Silva";
        Q11.respostacorreta = 1;
        ListaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.nivelpergunta = 1;
        Q12.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q12.pergunta = "Qual jogador usa o shampoo clear?";
        Q12.resposta1 = "Cristiano Ronaldo";
        Q12.resposta2 = "Dunga";
        Q12.resposta3 = "Alex";
        Q12.resposta4 = "Zico";
        Q12.resposta5 = "Messi";
        Q12.respostacorreta = 1;
        ListaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.nivelpergunta = 1;
        Q13.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q13.pergunta = "Qual jogador brasileiro é conhecido como 'O Mágico'?";
        Q13.resposta1 = "Zico";
        Q13.resposta2 = "Rivaldo";
        Q13.resposta3 = "Ronaldinho Gaúcho";
        Q13.resposta4 = "Kaká";
        Q13.resposta5 = "Pelé";
        Q13.respostacorreta = 3;
        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.nivelpergunta = 1;
        Q14.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q14.pergunta = "Qual é o nome do famoso torneio que reúne os principais clubes da América do Sul?";
        Q14.resposta1 = "Copa do Brasil";
        Q14.resposta2 = "Copa Libertadores";
        Q14.resposta3 = "Copa Sudamericana";
        Q14.resposta4 = "Copa América";
        Q14.resposta5 = "Campeonato Brasileiro";
        Q14.respostacorreta = 2;
        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.nivelpergunta = 1;
        Q15.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q15.pergunta = "Quem é o jogador brasileiro que se destacou na Copa de 1998?";
        Q15.resposta1 = "Ronaldo";
        Q15.resposta2 = "Cafu";
        Q15.resposta3 = "Rivaldo";
        Q15.resposta4 = "Romário";
        Q15.resposta5 = "Taffarel";
        Q15.respostacorreta = 1;
        ListaQuestoes.Add(Q15);

          var Q16 = new Questao();
        Q16.nivelpergunta = 1;
        Q16.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q16.pergunta = "Qual é o maior artilheiro da história do Campeonato Brasileiro?";
        Q16.resposta1 = "Edmundo";
        Q16.resposta2 = "Romário";
        Q16.resposta3 = "Roberto Dinamite";
        Q16.resposta4 = "Zico";
        Q16.resposta5 = "Bebeto";
        Q16.respostacorreta = 3;
        ListaQuestoes.Add(Q16);

          var Q17 = new Questao();
        Q17.nivelpergunta = 1;
        Q17.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q17.pergunta = "Quem foi o jogador que mais fez gols na história do Santos?";
        Q17.resposta1 = "Neymar";
        Q17.resposta2 = "Pelé";
        Q17.resposta3 = "Robinho";
        Q17.resposta4 = "Jairzinho";
        Q17.resposta5 = "Edu";
        Q17.respostacorreta = 2;
        ListaQuestoes.Add(Q17);

          var Q18 = new Questao();
        Q18.nivelpergunta = 1;
        Q18.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q18.pergunta = "Quem é o treinador brasileiro que conquistou a Copa do Mundo em 2002?";
        Q18.resposta1 = "Carlos Alberto Parreira";
        Q18.resposta2 = "Dunga";
        Q18.resposta3 = "Tite";
        Q18.resposta4 = "Felipão";
        Q18.resposta5 = "Zagallo";
        Q18.respostacorreta = 4;
        ListaQuestoes.Add(Q18);

          var Q19 = new Questao();
        Q19.nivelpergunta = 1;
        Q19.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q19.pergunta = "Qual time é conhecido como o 'Rei do Rio'?";
        Q19.resposta1 = "Fluminense";
        Q19.resposta2 = "Flamengo";
        Q19.resposta3 = "Vasco";
        Q19.resposta4 = "Botafogo";
        Q19.resposta5 = "América-RJ";
        Q19.respostacorreta = 2;
        ListaQuestoes.Add(Q19);

         var Q20 = new Questao();
        Q20.nivelpergunta = 1;
        Q20.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q20.pergunta = "Quem é o maior artilheiro da Seleção Brasileira em Copas do Mundo?";
        Q20.resposta1 = "Ronaldo";
        Q20.resposta2 = "Pelé";
        Q20.resposta3 = "Rivaldo";
        Q20.resposta4 = "Tostão";
        Q20.resposta5 = "Romário";
        Q20.respostacorreta = 1;
        ListaQuestoes.Add(Q20);

         var Q21 = new Questao();
        Q21.nivelpergunta = 1;
        Q21.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q21.pergunta = "Quem é o treinador da Seleção Brasileira em 2022?";
        Q21.resposta1 = "Tite";
        Q21.resposta2 = "Dunga";
        Q21.resposta3 = "Zagallo";
        Q21.resposta4 = "Fernando Diniz";
        Q21.resposta5 = "Luxemburgo";
        Q21.respostacorreta = 1;
        ListaQuestoes.Add(Q21);

         var Q22 = new Questao();
        Q22.nivelpergunta = 1;
        Q22.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q22.pergunta = "Qual jogador brasileiro foi eleito o melhor do mundo pela FIFA em 1999?";
        Q22.resposta1 = "Ronaldo";
        Q22.resposta2 = "Rivaldo";
        Q22.resposta3 = "Kaká";
        Q22.resposta4 = "Ronaldinho Gaúcho";
        Q22.resposta5 = "Pelé";
        Q22.respostacorreta = 2;
        ListaQuestoes.Add(Q22);

        var Q23 = new Questao();
        Q23.nivelpergunta = 1;
        Q23.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q23.pergunta = "Qual seleção foi derrotada pelo Brasil na final da Copa do Mundo de 1970?";
        Q23.resposta1 = "Alemanha Ocidental";
        Q23.resposta2 = "Itália";
        Q23.resposta3 = "Uruguai";
        Q23.resposta4 = "Argentina";
        Q23.resposta5 = "França";
        Q23.respostacorreta = 2;
        ListaQuestoes.Add(Q23);





        ProximaQuestao();
    }

    public async void VerificaResposta(int RR)
    {
        if (QuestaoAtual.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await Task.Delay(1000);
            await App.Current.MainPage.DisplayAlert("Burro", "Fim", "Ok");
            Inicializar();
        }
        if (NivelAtual == 10)
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Acabou!", "Ok");
            Inicializar();
        }
        LabelPont.Text = "Pontuação:R$" + Pontuacao.ToString();
        LabelNivel.Text = "Nível:" + NivelAtual.ToString();
    }

    void ProximaQuestao()
    {
        var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
            numAleat = Random.Shared.Next(0, ListaQuestoes.Count);

        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoAtual = ListaQuestoes[numAleat];
        QuestaoAtual.desenhar();
    }
    void Inicializar()
    {
        ListaQuestoesRespondidas.Clear();
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if (n == 1)
            Pontuacao = 1000;
        else if (n == 2)
            Pontuacao = 2000;
        else if (n == 3)
            Pontuacao = 3000;
        else if (n == 4)
            Pontuacao = 5000;
        else if (n == 5)
            Pontuacao = 10000;
        else if (n == 5)
            Pontuacao = 20000;
        else if (n == 6)
            Pontuacao = 50000;
        else if (n == 7)
            Pontuacao = 100000;
        else if (n == 8)
            Pontuacao = 200000;
        else if (n == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;


    }
}