namespace EJERCICIOSMENU;

public partial class Dinero : ContentPage
{
	public Dinero()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {



        if (double.TryParse(costEntry.Text, out double cost) && double.TryParse(moneyGivenEntry.Text, out double moneyGiven))
        {
            double change = moneyGiven - cost;
            if (change >= 0)
            {
                resultLabel.Text = $"El cambio es: {change:C2}";
            }
            else
            {
                resultLabel.Text = "El dinero entregado es insuficiente.";
            }
        }
        else
        {
            resultLabel.Text = "Por favor, ingrese valores válidos.";
        }



    }
}