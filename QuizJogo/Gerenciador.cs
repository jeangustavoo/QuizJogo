namespace QuizJogo;

public class Gerenciador
{
    public int Pontuacao{get; private set;}
    int NivelAtual=1;
    List<Questao> ListaQuestoes=new List<Questao>();
    List<int> ListaQuestoesRespondidas=new List<int>();
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
        var Q1=new Questao();
        Q1.nivelpergunta=1;
        Q1.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q1.pergunta="Quem é o maior artilheiro da história da Seleção Brasileira?";
        Q1.resposta1="Neymar";
        Q1.resposta2="Ronaldo";
        Q1.resposta3="Bebeto";
        Q1.resposta4="Pele";
        Q1.resposta5="Ribamar";
        Q1.respostacorreta=04;
        ListaQuestoes.Add(Q1);

        var Q2=new Questao();
        Q2.nivelpergunta=1;
        Q2.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q2.pergunta="Qual é o estádio mais famoso do Brasil?";
        Q2.resposta1="Vila Belmiro";
        Q2.resposta2="Maracanã";
        Q2.resposta3="Morumbi";
        Q2.resposta4="Minerão";
        Q2.resposta5="Engenhão";
        Q2.respostacorreta=02;
        ListaQuestoes.Add(Q2);

        var Q3=new Questao();
        Q3.nivelpergunta=1;
        Q3.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q3.pergunta="Qual time não tem mundial?";
        Q3.resposta1="Santos";
        Q3.resposta2="Internacional";
        Q3.resposta3="Corinthians";
        Q3.resposta4="Palmeiras";
        Q3.resposta5="Flamengo";
        Q3.respostacorreta=04;
        ListaQuestoes.Add(Q3);

         var Q4=new Questao();
         Q4.nivelpergunta=1;
        Q4.ConfigurarEstruturaDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q4.pergunta="Qual time é bambi?";
        Q4.resposta1="Santos";
        Q4.resposta2="Internacional";
        Q4.resposta3="São Paulo";
        Q4.resposta4="Palmeiras";
        Q4.resposta5="Flamengo";
        Q4.respostacorreta=03;
        ListaQuestoes.Add(Q4);


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
        await App.Current.MainPage.DisplayAlert("Burro", "Fim","Ok");
        Inicializar();
    }
    LabelPont.Text="Pontuação:R$"+Pontuacao.ToString();
        LabelNivel.Text="Nível:"+NivelAtual.ToString();
    }

    void ProximaQuestao()
    {
        var numAleat=Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
            numAleat=Random.Shared.Next(0, ListaQuestoes.Count);

        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoAtual=ListaQuestoes[numAleat];
        QuestaoAtual.desenhar();
    }
    void Inicializar()
    {
        Pontuacao=0;
        NivelAtual=1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if(n==1)
            Pontuacao=1000;
        else if(n==2)
            Pontuacao=2000;
        else if(n==3)
            Pontuacao=3000;
        else if(n==4)
            Pontuacao=5000;
        else if(n==5)
            Pontuacao=10000;
        else if(n==5)
            Pontuacao=20000;
        else if(n==6)
            Pontuacao=50000;
        else if(n==7)
            Pontuacao=100000;
        else if(n==8)
            Pontuacao=200000;
        else if(n==9)
            Pontuacao=500000;
        else 
            Pontuacao=1000000;


    }
}