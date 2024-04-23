namespace horariodamalu;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	void TestaLayout();
	{
		Results= new Results();
		Results.temp=23;
		Results.Description="Sol";
		Results.Rain=10;
		Results.City="Apucarana, PR";
		Results.Currently= "Dia";

	}
	void Preencher Tela();
	{
		LabelChuva.Text=Results.Rain;
		LabelUmidade.Text=Results.Humidity;
		LabelTemp.Text=Results.Temp;
	}
	

}