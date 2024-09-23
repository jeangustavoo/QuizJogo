namespace QuizJogo;

public partial class TelaInicial : ContentPage
{
    public TelaInicial()
    {
        InitializeComponent();
        
    }

    void BtnIniciarClicado(object sender, EventArgs args)
    {
        Application.Current.MainPage= new MainPage();
    }
}