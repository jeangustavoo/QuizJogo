﻿namespace QuizJogo;

public partial class MainPage : ContentPage
{
	  Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(Perguntas, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);

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
}
