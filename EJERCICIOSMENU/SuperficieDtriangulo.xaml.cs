namespace EJERCICIOSMENU;

public partial class SuperficieDtriangulo : ContentPage
{
    /// <summary>
    /// Programa que calcula el perimetro de un triangulo
    /// </summary>
    public SuperficieDtriangulo()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evento del boton que calcula los datos para mostrar resultado
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double a, b, p;
        a = Convert.ToDouble(entria.Text);
        b = Convert.ToDouble(entrib.Text);
        p = b * a / 2;
        entrip.Text = p.ToString();
    }
}