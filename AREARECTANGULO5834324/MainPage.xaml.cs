using static System.Net.Mime.MediaTypeNames;

namespace AREARECTANGULO5834324;

public partial class MainPage : ContentPage
{

    /// <summary>
    /// <Createddate>22/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>24/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL LABEL
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>

    public MainPage()
	{
		InitializeComponent();
	}


	/// <summary>
	/// SE EJECUTA EL PRESIONAR EL BOTON
	/// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double b = Convert.ToDouble(bas.Text);
        double a = Convert.ToDouble(altu.Text);

        p.Text = "El perímetro es: " + (b + b + a + a);
        s.Text = "La superficie es: " + (b * a);
    }
}

