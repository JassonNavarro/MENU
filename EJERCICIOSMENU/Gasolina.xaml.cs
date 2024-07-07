namespace EJERCICIOSMENU;

public partial class Gasolina : ContentPage
{
	public Gasolina()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        const double gallonsToLiters = 3.78541;


        if (double.TryParse(GallonsEntry.Text, out double gallons) &&
            double.TryParse(PricePerLiterEntry.Text, out double pricePerLiter))
        {

            double liters = gallons * gallonsToLiters;
            double totalCost = liters * pricePerLiter;


            ResultLabel.Text = $"El costo total es: ${totalCost:F2}";
        }
        else
        {

            ResultLabel.Text = "Por favor, ingrese valores válidos.";
        }



    }
}