namespace QuizJogo;

public partial class MainPage : ContentPage
{
	  Gerenciador gerenciador;
	  int pula=0;
	  

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(Perguntas, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, LabelPont, LabelNivel);

	}
	void btnResposta01Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(1);
	}
	 	
	void btnResposta02Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(2);
	}
	void btnResposta03Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(3);
	}
	void btnResposta04Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(4);
	}
	void btnResposta05Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(5);
	}
	void ajudarbtnPular (object s,EventArgs e)
	{
		if (pula==2)
		(s as Button).IsVisible = false;
		else
		{
			gerenciador.ProximaQuestao();
			pula++;
		}
		ajudarbtnPular
		

}
