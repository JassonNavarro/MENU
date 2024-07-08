namespace EJERCICIOSMENU;

public partial class Pesodino : ContentPage
{
	public Pesodino()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (double.TryParse(txtPeso.Text, out double pesoKg) && double.TryParse(txtAltura.Text, out double alturaMetros))
        {
            // Convertir peso de kg a libras (1 kg = 2.20462 libras)
            double pesoLibras = pesoKg * 2.20462;

            // Convertir altura de metros a cent�metros (1 metro = 100 cent�metros)
            double alturaCentimetros = alturaMetros * 100;

            // Mostrar resultados
            lblResultado.Text = $"Dinosaurio: {txtNombre.Text}\n" +
                                $"Peso en libras: {pesoLibras:F2} lbs\n" +
                                $"Altura en cent�metros: {alturaCentimetros:F2} cm";
        }
        else
        {
            lblResultado.Text = "Por favor ingrese valores num�ricos v�lidos para peso y altura.";
        }

    }
}